using System.IO;
using UnityEngine;

namespace Helper
{
    /// <summary>
    /// Perform IO operations on files in <see cref="Application.persistentdatapath"/>.
    /// </summary>
    internal static class PersistentPathIO
    {
        /// <summary>
        /// Does the file exist at the given path in persistent path directory?
        /// </summary>
        internal static bool Exists(string path)
        {
            return File.Exists(Application.persistentDataPath + "/" + path);
        }

        /// <summary>
        /// Load file at the given path in persistent path directory.
        /// Throws exception if file does not exist.
        /// </summary>
        internal static string LoadFile(string path)
        {
            if (!Exists(path))
                throw new System.Exception("File does not exist!");

            return File.ReadAllText(Application.persistentDataPath + "/" + path);
        }

        /// <summary>
        /// Saves file at the given path with data in the persistent path directory.
        /// If the file does not exist, it is created.
        /// </summary>
        internal static void SaveFile(string path, string data)
        {
            var p = Application.persistentDataPath + "/" + path;
            if (!File.Exists(p))
            {
                var fs = new FileStream(p, FileMode.Create);
                fs.Dispose();
            }

            File.WriteAllText(p, data);
        }
    }
}