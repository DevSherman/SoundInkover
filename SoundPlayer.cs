using System;
using WMPLib;

namespace SoundInvoker
{
    public class SoundPlayer
    {
        private int buffer;
        private int index;
        private WindowsMediaPlayer[] mplayer;

        public SoundPlayer(int buffer_size = 25)
        {
            buffer = buffer_size;
            index = 0;
            mplayer = new WindowsMediaPlayer[buffer_size];

            for (int i = 0; i < buffer_size; i++)
            {
                mplayer[i] = new WindowsMediaPlayer();
            }
        }

        public void Reset(int buffer_size)
        {
            if (buffer == buffer_size) return;

            for (int i = 0; i < buffer; i++)
            {
                mplayer[i].URL = "";
                mplayer[i].controls.stop();
            }

            buffer = buffer_size;
            index = 0;
            mplayer = new WindowsMediaPlayer[buffer_size];

            for (int i = 0; i < buffer_size; i++)
            {
                mplayer[i] = new WindowsMediaPlayer();
            }
        }

        public void Play(string url)
        {
            if (Loaded(url)) { }
            else
            {
                mplayer[index].URL = url;
                mplayer[index].controls.play();
                index++;
            }

            if (index > buffer - 1) index = 0; 
        }
        public void SetVolume(int volume)
        {
            for (int i = 0; i < mplayer.Length; i++)
            {
                mplayer[i].settings.volume = volume;
            }
        }
        public bool Loaded(string url)
        {
            for (int i = 0; i < mplayer.Length; i++)
            {
                if(mplayer[i].URL == url)
                {
                    mplayer[i].controls.stop();
                    mplayer[i].URL = "";
                    return true;
                }
            }
            return false;
        }

        internal void Stop(string path)
        {
            Loaded(path);
        }
    }
}
