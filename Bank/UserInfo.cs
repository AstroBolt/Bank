using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using System.Security.Cryptography;
using System.IO;

namespace Bank
{
    public class UserInfo
    {
        public UserInfo()
        {
        }

        public void AddDataEntry(DataEntry data)
        {
            data.Id = dataEntryByDate.Count;
            data.DateCreated = DateTime.Now;
            dataEntryByDate.Add(data);
            dataEntryByValue.Add(data);
            dataEntryByDateCreated.Add(data);
            Console.WriteLine("Added entry");
        }

        public void AddTag(string tagName) { tags.AddTag(tagName); }

        private string ConvertDataEntryToString(DataEntry dataEntry)
        {
            string dataEntryString = string.Empty;
            dataEntryString += dataEntry.Id.ToString() + "\r\n" + dataEntry.Description + "\r\n" + dataEntry.Date + "\r\n" + dataEntry.TagsToString(dataEntry.Tags) + "\r\n";
            return dataEntryString;
        }

        private string ConvertUserInfoToString()
        {
            string output = string.Empty;
            if (dataEntryByDate.Count != 0)
            {
                foreach (DataEntry dataEntry in dataEntryByDate)
                {
                    output += ConvertDataEntryToString(dataEntry);
                }
            }
            output += tags.GetTagsAsString();
            return output;
        }

        public List<DataEntry> GetDataEntryListByDate()
        {
            return new List<DataEntry>(dataEntryByDate);
        }

        public List<DataEntry> GetDataEntryListByDateCreated()
        {
            return new List<DataEntry>(dataEntryByDateCreated);
        }

        public List<DataEntry> GetDataEntryListByValue()
        {
            return new List<DataEntry>(dataEntryByValue);
        }

        public int GetDataEntryCount()
        {
            return dataEntryByDate.Count;
        }

        public string[] GetTagsArray() { return tags.GetArray(); }

        public void LoadUserInfo(string file)
        {
            UserInfoDataPackage userInfoDataPackage = ReadUserInfo(file);
            dataEntryByDate = new SortedSet<DataEntry>(userInfoDataPackage.DataEntries, new ComparerDataEntryByDate());
            dataEntryByValue = new SortedSet<DataEntry>(dataEntryByDate, new ComparerDataEntryByValue());
            dataEntryByDateCreated = new SortedSet<DataEntry>(dataEntryByDate, new ComparerDataEntryByDateCreated());
            tags.ImportTagSet(new SortedSet<string>(userInfoDataPackage.Tags));
            Console.WriteLine(tags.GetCount());
        }

        public void SaveUserInfo(string file)
        {
            List<DataEntry> dataEntrySortedSet = new List<DataEntry>(dataEntryByDate);
            List<string> tagSortedSet = new List<string>(tags.ExportTagSet());
            UserInfoDataPackage userInfoDataPackage = new UserInfoDataPackage(ref dataEntrySortedSet, ref tagSortedSet);
            WriteUserInfo(file, userInfoDataPackage);
        }

        private Tags tags = new Tags();

        private SortedSet<DataEntry> dataEntryByDate = new SortedSet<DataEntry>(new ComparerDataEntryByDate());
        private SortedSet<DataEntry> dataEntryByValue = new SortedSet<DataEntry>(new ComparerDataEntryByValue());
        private SortedSet<DataEntry> dataEntryByDateCreated = new SortedSet<DataEntry>(new ComparerDataEntryByDate());

        private UserInfoDataPackage ReadUserInfo(string file)
        {
            UserInfoDataPackage result;
            using (StreamReader sw = new StreamReader(file))
            {
                result = JsonConvert.DeserializeObject<UserInfoDataPackage>(sw.ReadToEnd());
                sw.Close();
            }
            return result;
        }

        private void WriteUserInfo(string file, UserInfoDataPackage userInfoDataPackage)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(JsonConvert.SerializeObject(userInfoDataPackage));
            }
        }
    }

    class ComparerDataEntryByDate : IComparer<DataEntry>
    {
        public int Compare(DataEntry left, DataEntry right)
        { 
            if (DateTime.Parse(left.Date).CompareTo(DateTime.Parse(right.Date)) == 0)
            {
                return 1;
            }
            return DateTime.Parse(left.Date).CompareTo(DateTime.Parse(right.Date));
        }
    }

    class ComparerDataEntryByValue : IComparer<DataEntry>
    {
        public int Compare(DataEntry left, DataEntry right)
        {
            if (left.Value == right.Value)
            {
                return 1;
            }
            return left.Value.CompareTo(right.Value);
        }
    }

    class ComparerDataEntryByDateCreated : IComparer<DataEntry>
    {
        public int Compare(DataEntry left, DataEntry right)
        {
            if (DateTime.Compare(left.DateCreated, right.DateCreated) == 0)
            {
                return 1;
            }
            return DateTime.Compare(left.DateCreated, right.DateCreated);
        }
    }

    class Tags
    {

        public Tags()
        {
        }

        public void AddTag(string t)
        {
            tags.Add(t);
        }

        public SortedSet<string> ExportTagSet()
        {
            SortedSet<string> tagsSet = new SortedSet<string>(tags);
            return tagsSet;
        }

        public string GetTagsAsString()
        {
            string output = string.Empty;
            if (tags.Count != 0)
            {
                foreach (string s in tags)
                {
                    output += s + "\r\n";
                }
            }
            return output;
        }

        public string[] GetArray()
        {
            List<string> tagsList = new List<string>();
            if (tags != null)
            {
                foreach (string tag in tags)
                {
                    tagsList.Add(tag);
                }
                return tagsList.ToArray();
            }
            return null;
        }

        public int GetCount()
        {
            return tags.Count;
        }

        public void ImportTagSet(SortedSet<string> tagSet)
        {
            tags = tagSet;
        }

        private SortedSet<string> tags = new SortedSet<string>();
    }

    class UserInfoDataPackage
    {
        public List<DataEntry> DataEntries;
        public List<string> Tags;

        public UserInfoDataPackage(ref List<DataEntry> _DataEntries, ref List<string> _Tags)
        {
            DataEntries = _DataEntries;
            Tags = _Tags;
        }
    }

    

        //public static class Encrypt
        //{
        //    // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        //    // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        //    private const string initVector = "lkiuv562nmjk2f90";
        //    // This constant is used to determine the keysize of the encryption algorithm
        //    private const int keysize = 256;
        //    //Encrypt
        //    public static string EncryptString(string plainText, string passPhrase)
        //    {
        //        byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
        //        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        //        PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
        //        byte[] keyBytes = password.GetBytes(keysize / 8);
        //        RijndaelManaged symmetricKey = new RijndaelManaged();
        //        symmetricKey.Mode = CipherMode.CBC;
        //        ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
        //        MemoryStream memoryStream = new MemoryStream();
        //        CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
        //        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        //        cryptoStream.FlushFinalBlock();
        //        byte[] cipherTextBytes = memoryStream.ToArray();
        //        memoryStream.Close();
        //        cryptoStream.Close();
        //        return Convert.ToBase64String(cipherTextBytes);
        //    }
        //    //Decrypt
        //    public static string DecryptString(string cipherText, string passPhrase)
        //    {
        //        byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
        //        byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
        //        PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
        //        byte[] keyBytes = password.GetBytes(keysize / 8);
        //        RijndaelManaged symmetricKey = new RijndaelManaged();
        //        symmetricKey.Mode = CipherMode.CBC;
        //        ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
        //        MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
        //        CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
        //        byte[] plainTextBytes = new byte[cipherTextBytes.Length];
        //        int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
        //        memoryStream.Close();
        //        cryptoStream.Close();
        //        return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        //    }
        //}


    }
