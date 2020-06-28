using System;
using System.Collections.Generic;
using System.Linq;
namespace SoundInvoker
{
    [System.Serializable]
    public class SoundItem
    {
        public int ID;
        public string name;
        public string path;
        public string key1;
        public string key2;

        public SoundItem(int id = -1, string name="", string path="", string key1="", string key2="")
        {
            this.ID = id;
            this.name = name;
            this.path = path;
            this.key1 = key1;
            this.key2 = key2;
        }
    }
}
