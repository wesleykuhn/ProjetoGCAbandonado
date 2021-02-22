using System;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace GC.Library.Sounds
{
    internal class Speech
    {
        private static Task[] Row1 = Array.Empty<Task>();
        private static Task[] Row2 = Array.Empty<Task>();

        /// <summary>
        /// Create a new task, with the speak on it, and puts it on the execution row.
        /// </summary>
        /// <param name="text"></param>
        internal static void AddSpeechToSpeakRow_TaskRun(string text)
        {
            Task.Run(() => AddSpeechToSpeakRow(text));
        }

        /// <summary>
        /// Create a new task, with the speak on it, and puts it on the execution row.
        /// </summary>
        /// <param name="text"></param>
        internal static void AddSpeechToSpeakRow(string text)
        {
            if (text == null || text == "") return;

            byte rowToUse = 1;

            if(Row1.Length > 0)
            {
                foreach (Task task in Row1)
                {
                    if (!task.IsCompleted)
                    {
                        rowToUse = 2;
                        break;
                    }
                }
            }            

            if (rowToUse == 1)
            {
                if(Row1.Length > 0)
                {
                    Array.Resize<Task>(ref Row1, Row1.Length + 1);
                    Array.Copy(new Task[] { CreateSpeechTask(text) }, 0, Row1, Row1.Length, 1);                    
                }
                else
                {
                    Row1 = new Task[] { CreateSpeechTask(text) };
                }

                PlayRow1();
            }

            if(rowToUse == 2)
            {
                if(Row2.Length > 0)
                {
                    Array.Resize<Task>(ref Row2, Row2.Length + 1);
                    Array.Copy(new Task[] { CreateSpeechTask(text) }, 0, Row2, Row2.Length, 1);
                }
                else
                {
                    Row2 = new Task[] { CreateSpeechTask(text) };
                }

                PlayRow2();
            }
        }

        private static void PlayRow1()
        {
            if(Row2.Length > 0)
            {
                Task.WaitAll(Row2);
            }            

            foreach (Task task in Row1)
            {
                task.RunSynchronously();
            }

            Row1 = Array.Empty<Task>();
        }

        private static void PlayRow2()
        {
            if(Row1.Length > 0)
            {
                Task.WaitAll(Row1);
            }            

            foreach (Task task in Row2)
            {
                task.RunSynchronously();
            }

            Row2 = Array.Empty<Task>();
        }        

        private static Task CreateSpeechTask(string text)
        {
            return new Task(new Action(() =>
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();
                synth.Volume = 100;
                synth.Speak(text);
                synth.Dispose();
            }));
        }
    }
}
