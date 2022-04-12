using System.IO;
using UnityEngine;

namespace Helper
{
    internal class PersistentPathIO
    {
        internal bool Exists(string path)
        {
            return File.Exists(Application.persistentDataPath + "/" + path);
        }

        internal string LoadFile(string path)
        {
            if (!File.Exists(Application.persistentDataPath + "/" + path))
                throw new System.Exception("File does not exist!");

            return File.ReadAllText(Application.persistentDataPath + "/" + path);
        }

        internal void SaveFile(string path, string data)
        {
            var p = Application.persistentDataPath + "/" + path;
            if (!File.Exists(p))
                File.Create(p);

            File.WriteAllText(p, data);
        }
    }
}