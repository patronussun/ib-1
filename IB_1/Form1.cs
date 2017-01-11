using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace IB_1
{
    public partial class Form1 : Form
    {
        public static byte[] KEY = Encoding.Default.GetBytes("h2c_d~Ah408Fdh5+");
        public static byte[] IV = Encoding.Default.GetBytes(">s78*91-");

        User currentUser;
        UsersCatalog Users;
        int failLoginNumber = 0;
        
        public Form1()
        {
            InitializeComponent();
            panelLK.Visible = false;
            panelAD.Visible = false;

            Users = new UsersCatalog();
            Users.Data = new List<User>();

            //check if started first time than generate catalog file
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\UsersENC.xml"))
            {
                User admin = new User();
                admin.Login = "ADMIN";
                admin.Password = "";
                admin.isAdmin = true;
                admin.isBlocked = false;
                admin.isPasswordRestricted = false;
                Users.Data.Add(admin);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Васильева Мария, ИСЭбд-41");
        }

        /// <summary>
        /// Нажатие на кнопку входа в систему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User u in Users.Data)
                if (tbLogin.Text == u.Login && (MD5(tbPassword.Text) == u.Password && tbPassword.Text !="" || tbPassword.Text == "") && u.isBlocked == false)
                {
                    входToolStripMenuItem.Enabled = false;
                    личныйКабинетToolStripMenuItem.Enabled = true;
                    if(u.isAdmin == true)
                        администрированиеToolStripMenuItem.Enabled = true;
                    panelLK.Visible = true;
                    gbEnter.Visible = false;

                    tbLogin.Text = null;
                    tbPassword.Text = null;

                    currentUser = u;
                    failLoginNumber = 0;
                    return;
                }
                else if (tbLogin.Text == u.Login && (MD5(tbPassword.Text) == u.Password && tbPassword.Text != "" || tbPassword.Text == "") && u.isBlocked == true)
                {
                    MessageBox.Show("Пользователь заблокирован");
                    tbLogin.Text = null;
                    tbPassword.Text = null;
                    failLoginNumber = 0;
                    return;
                }

            //if there is no user with this data
            MessageBox.Show("Ошибка ввода логина и пароля");
            failLoginNumber += 1;
            if (failLoginNumber == 3)
            {
                MessageBox.Show("Пароль введен три раза неправильно! Выход");
                Application.Exit();
            }

        }

        /// <summary>
        /// Нажатие на кнопку выхода из системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            входToolStripMenuItem.Enabled = true;
            личныйКабинетToolStripMenuItem.Enabled = false;
            администрированиеToolStripMenuItem.Enabled = false;
            panelLK.Visible = false;
            gbEnter.Visible = true;
            currentUser = null;
        }

        /// <summary>
        /// Проверка пароля на соответствие ограничениям
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool isPasswordRestrictionsOkay(string s)
        {
            string alpha = "1234567890-_,.!;:?()";
            foreach (char c in s)
            {
                if (!alpha.Contains(c))
                    return false;
            }
            return true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            if ((MD5(tbOldPassword.Text) == currentUser.Password && tbOldPassword.Text != "" || tbOldPassword.Text == "") && tbNewPassword.Text == tbNewPasswordAgain.Text && ((isPasswordRestrictionsOkay(tbNewPassword.Text) && currentUser.isPasswordRestricted == true) || currentUser.isPasswordRestricted == false))
            {
                MessageBox.Show("Пароль изменен успешно!");
                currentUser.Password = tbNewPassword.Text;
                for (int i = 0; i < Users.Data.Count; i++)
                {
                    if (Users.Data[i].Login == currentUser.Login && tbNewPassword.Text != "")
                    {
                        Users.Data[i].Password = MD5(currentUser.Password);
                    }
                }
                tbOldPassword.Text = null;
                tbNewPassword.Text = null;
                tbNewPasswordAgain.Text = null;
            }
            else
            {
                MessageBox.Show("Ошибка при смене пароля.");
            }
        }

        /// <summary>
        ///  В момент выхода из программы необходимо пересохранить данные
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsersCatalog));
            FileStream fs = new FileStream("UsersDEC.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            xmlSerializer.Serialize(fs, Users);
            fs.Close();

            //Encrypt this file now
            string xmlFileText = File.ReadAllText("UsersDEC.xml");

            //CREATE HASH FILE
            string HASH = MD5(xmlFileText);
            File.WriteAllText("UsersCatalogHASH.txt", HASH);

            //Encrypt
            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            {
                myTripleDES.Mode = CipherMode.ECB;
                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes(xmlFileText, KEY, IV);

                //Save array of bytes
                File.WriteAllBytes("UsersENC.xml", encrypted);

                //Delete decrypted file
                File.Delete("UsersDEC.xml");
            }

        }

        /// <summary>
        /// получение MD5-хеша
        /// </summary>
        /// <param name="input">входная строка</param>
        /// <returns>хеш</returns>
        /// 
        public static string MD5(string input)
        {
            byte[] hash;
            using (var md5 = new MD5CryptoServiceProvider())
            {
                hash = md5.ComputeHash(Encoding.Unicode.GetBytes(input));
            }

            StringBuilder sb = new StringBuilder();
            foreach(byte b in hash)
            {
                sb.AppendFormat("{0:X2}",b);
            }
            return sb.ToString();
        }

        /// <summary>
        /// ENCRYPTION FUNCTION
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns>Encrypted byte array</returns>
        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        /// <summary>
        /// DECRYPTION FUNCTION
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns>Decrypted string</returns>
        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using ( TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        
        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLK.Visible = true;
            panelAD.Visible = false;
            gbEnter.Visible = false;
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLK.Visible = false;
            panelAD.Visible = true;
            gbEnter.Visible = false;

            updateListUsers();
        }

        /// <summary>
        /// Вызывается при необходимости обновить таблицу с пользователями
        /// </summary>
        public void updateListUsers()
        {
            listUsers.Items.Clear();
            foreach (User u in Users.Data)
            {
                string tmp = u.Login;
                tmp += "|"; //Separator to handle login
                tmp += "\tБлокировка = ";
                tmp += u.isBlocked;
                tmp += "\tОграничение = ";
                tmp += u.isPasswordRestricted;
                listUsers.Items.Add(tmp);
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            foreach(User u in Users.Data)
            {
                if (u.Login == tbAddNewUser.Text)
                {
                    MessageBox.Show("Логин уже существует");
                    tbAddNewUser.Text = "";
                    return;
                }
            }
            User newUser = new User();
            newUser.Login = tbAddNewUser.Text;
            newUser.Password = "";
            newUser.isAdmin = false;
            newUser.isBlocked = false;
            newUser.isPasswordRestricted = true;
            Users.Data.Add(newUser);
            tbAddNewUser.Text = "";

            updateListUsers();
        }

        /// <summary>
        /// Удаление пользователя при нажатии на кнопку удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null)
                return;
            string selected = listUsers.GetItemText(listUsers.SelectedItem);
            
            string[] tmp = selected.Split('|');
            //Delete if login same
            for (int i = 0; i < Users.Data.Count; i++)
            {
                if (tmp[0] == Users.Data[i].Login)
                {
                    Users.Data.RemoveAt(i);
                    break;
                }
            }

            updateListUsers();
        }

        /// <summary>
        /// Изменение ограничений на пароль
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitchPassRestr_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null)
                return;
            string selected = listUsers.GetItemText(listUsers.SelectedItem);

            string[] tmp = selected.Split('|');

            for (int i = 0; i < Users.Data.Count; i++)
            {
                if (tmp[0] == Users.Data[i].Login)
                {
                    if (!Users.Data[i].isPasswordRestricted)
                        Users.Data[i].isPasswordRestricted = true;
                    else
                        Users.Data[i].isPasswordRestricted = false;
                    break;
                }
            }

            updateListUsers();
        }

        /// <summary>
        /// Изменение ограничений на вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitchBlock_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null)
                return;
            string selected = listUsers.GetItemText(listUsers.SelectedItem);

            string[] tmp = selected.Split('|');

            for (int i = 0; i < Users.Data.Count; i++)
            {
                if (tmp[0] == Users.Data[i].Login)
                {
                    if (!Users.Data[i].isBlocked)
                        Users.Data[i].isBlocked = true;
                    else
                        Users.Data[i].isBlocked = false;
                    break;
                }
            }
            updateListUsers();
        }

        /// <summary>
        /// При запуске формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("UsersENC.xml"))
            {
                return;
            }
            byte[] decryptedFileBytes = File.ReadAllBytes("UsersENC.xml");

            using (TripleDESCryptoServiceProvider myTripleDES = new TripleDESCryptoServiceProvider())
            {
                myTripleDES.Mode = CipherMode.ECB; //шифрование

                string decrypted = DecryptStringFromBytes(decryptedFileBytes, KEY, IV);

                //Create temp file
                File.WriteAllText("UsersDEC.xml", decrypted);

                //Check if HASH good
                string readHASH = File.ReadAllText("UsersCatalogHASH.txt");
                if (MD5(decrypted) != readHASH)
                {
                    MessageBox.Show("Не удалось загрузить каталог: несовпадение хэша (ошибка в расшифровывании)");
                    Application.Exit();
                    return;
                }


                XmlSerializer xmlSerializer = new XmlSerializer(typeof(UsersCatalog));
                FileStream fs = new FileStream("UsersDEC.xml", FileMode.Open);
                XmlReader reader = XmlReader.Create(fs);
                Users = (UsersCatalog)xmlSerializer.Deserialize(reader);
                fs.Close();
                File.Delete(Directory.GetCurrentDirectory() + @"\UsersDEC.xml");
            }
        }
    }
}
