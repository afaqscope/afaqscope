using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Storage
{
    public class LocalStorage
    {
        private static string PROGRAM_FILES_X64_DIR = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
        private static string TEMP_LOCAL_STORAGE_DIR = PROGRAM_FILES_X64_DIR + "\\Temp\\AfaqScope";
        private static string BACKUP_STORAGE_DIR = PROGRAM_FILES_X64_DIR + "\\Backup\\AfaqScope";

        public static bool createTempDirectory()
        {
            try
            {
                if (!Directory.Exists(TEMP_LOCAL_STORAGE_DIR))
                    System.IO.Directory.CreateDirectory(TEMP_LOCAL_STORAGE_DIR);

                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("createTempDirectory", ex.StackTrace, ex.Message);
                return false;
            }
        }

        public static bool createBackupDirectory()
        {
            try
            {
                if (!Directory.Exists(BACKUP_STORAGE_DIR))
                    System.IO.Directory.CreateDirectory(BACKUP_STORAGE_DIR);

                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("createBackupDirectory", ex.StackTrace, ex.Message);
                return false;
            }
        }

        public static bool createFile(string fileName, string data)
        {
            try
            {
                string filePath = TEMP_LOCAL_STORAGE_DIR +"\\" + fileName + ".txt";
                if (!File.Exists(filePath))
                {
                    var file = File.Create(filePath);
                    file.Close();
                }
                else
                {
                    return false;
                }
                File.WriteAllText(filePath, data);
                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("createNewFile", ex.StackTrace, ex.Message);
                return false;
            }
        }

        public static bool updateFile(string fileName, string data)
        {
            try
            {
                string filePath = TEMP_LOCAL_STORAGE_DIR + "\\" + fileName + ".txt";
                if (!File.Exists(filePath))
                {
                    return false;
                }
                else
                {
                    File.WriteAllText(filePath, data);
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("updateFile", ex.StackTrace, ex.Message);
                return false;
            }
        }
        public static bool deleteFile(string fileName)
        {
            try
            {
                string filePath = TEMP_LOCAL_STORAGE_DIR + "\\" + fileName + ".txt";
                if (!File.Exists(filePath))
                {
                    return false;
                }
                else
                {
                    File.Delete(filePath);
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("deleteFile", ex.StackTrace, ex.Message);
                return false;
            }
        }

        public static bool createBackUp()
        {
            try
            {
                if (LocalStorage.createBackupDirectory())
                {
                    DirectoryInfo d = new DirectoryInfo(TEMP_LOCAL_STORAGE_DIR);
                    FileInfo[] Files = d.GetFiles("*.txt");

                    foreach (FileInfo file in Files)
                    {
                        File.Copy(TEMP_LOCAL_STORAGE_DIR + "\\" + file.Name, BACKUP_STORAGE_DIR + "\\" + file.Name);
                    }

                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.writeToLog("createBackUp", ex.StackTrace, ex.Message);
                return false;
            }
        }


        public static bool clearLocalStorage()
        {
            try
            {
                    DirectoryInfo d = new DirectoryInfo(TEMP_LOCAL_STORAGE_DIR);
                    FileInfo[] Files = d.GetFiles("*.txt");

                    foreach (FileInfo file in Files)
                    {
                       LocalStorage.deleteFile(file.Name);
                    }

                    return true;
            }
            catch (Exception ex)
            {
                Log.writeToLog("clearLocalStorage", ex.StackTrace, ex.Message);
                return false;
            }
        }
    }
}
