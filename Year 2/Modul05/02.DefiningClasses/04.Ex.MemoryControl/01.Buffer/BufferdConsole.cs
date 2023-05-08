using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _01.Buffer
{
    class BufferdConsole
    {
        private StreamWriter streamWriter;
        private const int MaxBufferSize = 50;
        private char[] buffer;
        private int index;

        public BufferdConsole()
        {
            buffer = new char[MaxBufferSize];
            index = 0;
            streamWriter = new StreamWriter("Result.txt");
        }
        public StreamWriter StreamWriter
        {
            get { return streamWriter; }
            set { streamWriter = value; }
        }

        public void Write(string text)
        {
            if (text.Length + index >= MaxBufferSize)
            {
                string bufferString = new string(buffer.Take(index).ToArray());
                string result = bufferString + text;
                streamWriter.Write(result);

                index = 0;
                return;
            }
            foreach (char letter in text)
            {
                this.buffer[index++] = letter;
            }
        }

        public void Dispose()
        {

        }
            

    }
}
