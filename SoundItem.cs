namespace SoundInvoker
{
    [System.Serializable]
    public class SoundItem
    {
        public string cmd;
        public string name;
        public string path;
        public string key1;
        public string key2;

        public SoundItem(string cmd = "", string name="", string path="", string key1="", string key2="")
        {
            this.cmd = cmd;
            this.name = name;
            this.path = path;
            this.key1 = key1;
            this.key2 = key2;
        }
    }
}
