namespace IELTSCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("        IELTS BALLARINI HISOBLASH KALKULYATORI ");
            Console.WriteLine("==============================================================\n");

            // ================= LISTENING =================
            double listeningValue1 = 0;
            bool savol1 = false;
            while (!savol1)
            {
                savol1 = true;
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine(" LISTENING (Tinglab tushunish)");
                Console.WriteLine("--------------------------------------------------------------");
                Savol40taNechtasigaTogriJavobBerdingiz();

                ListeningBall(Console.ReadLine(), ref listeningValue1);
                if (listeningValue1 == 10)
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    if (QaytaIshgaTushirishniAniqlash()) { savol1 = false; continue; }
                    else { return; }
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($" LISTENING yakuniy ball: {listeningValue1}");
                }
            }

            // ================= READING =================
            double readingValue1 = 0;
            bool savol2 = false;
            while (!savol2)
            {
                savol2 = true;
                Console.WriteLine("\n--------------------------------------------------------------");
                Console.WriteLine(" READING (O‘qish)");
                Console.WriteLine("--------------------------------------------------------------");
                Savol40taNechtasigaTogriJavobBerdingiz();

                ReadingBall(Console.ReadLine(), ref readingValue1);
                if (readingValue1 == 10)
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    if (QaytaIshgaTushirishniAniqlash()) { savol2 = false; continue; }
                    else { return; }
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($" READING yakuniy ball: {readingValue1}");
                }
            }

            // ================= WRITING =================
            Console.WriteLine("\n==============================================================");
            Console.WriteLine(" WRITING (Yozish)");
            Console.WriteLine("==============================================================");
            QuyidagiTasklardanOlinganBaholarniKiritish();

            double taskResponseValue = 0;
            bool savol3 = false;
            while (!savol3)
            {
                savol3 = true;
                Console.Write(" Task Response: ");
                if (double.TryParse(Console.ReadLine(), out taskResponseValue))
                {
                    if (taskResponseValue > 9 || taskResponseValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol3 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol3 = false; continue; }
                    else { return; }
                }
            }

            double taskCoherenceValue = 0;
            bool savol4 = false;
            while (!savol4)
            {
                savol4 = true;
                Console.Write(" Coherence/Cohesion: ");
                if (double.TryParse(Console.ReadLine(), out taskCoherenceValue))
                {
                    if (taskCoherenceValue > 9 || taskCoherenceValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol4 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol4 = false; continue; }
                    else { return; }
                }
            }

            double taskLexicalValue = 0;
            bool savol5 = false;
            while (!savol5)
            {
                savol5 = true;
                Console.Write(" Lexical Resource: ");
                if (double.TryParse(Console.ReadLine(), out taskLexicalValue))
                {
                    if (taskLexicalValue > 9 || taskLexicalValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol5 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol5 = false; continue; }
                    else { return; }
                }
            }

            double taskGrammarValue = 0;
            bool savol6 = false;
            while (!savol6)
            {
                savol6 = true;
                Console.Write(" Grammar: ");
                if (double.TryParse(Console.ReadLine(), out taskGrammarValue))
                {
                    if (taskGrammarValue > 9 || taskGrammarValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol6 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol6 = false; continue; }
                    else { return; }
                }
            }

            double writingValue11 = 0;
            WritingBall(taskResponseValue, taskCoherenceValue, taskLexicalValue, taskGrammarValue, ref writingValue11);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($" WRITING yakuniy ball: {writingValue11}");

            // ================= SPEAKING =================
            Console.WriteLine("\n==============================================================");
            Console.WriteLine(" SPEAKING (Gapirish)");
            Console.WriteLine("==============================================================");
            QuyidagiTasklardanOlinganBaholarniKiritish();

            double taskFluencyValue = 0;
            bool savol7 = false;
            while (!savol7)
            {
                savol7 = true;
                Console.Write(" Fluency and Coherence: ");
                if (double.TryParse(Console.ReadLine(), out taskFluencyValue))
                {
                    if (taskFluencyValue > 9 || taskFluencyValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol7 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol7 = false; continue; }
                    else { return; }
                }
            }

            double taskResourceValue = 0;
            bool savol8 = false;
            while (!savol8)
            {
                savol8 = true;
                Console.Write(" Lexical Resource: ");
                if (double.TryParse(Console.ReadLine(), out taskResourceValue))
                {
                    if (taskResourceValue > 9 || taskResourceValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol8 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol8 = false; continue; }
                    else { return; }
                }
            }

            double taskAccuracyValue = 0;
            bool savol9 = false;
            while (!savol9)
            {
                savol9 = true;
                Console.Write(" Grammatical Accuracy: ");
                if (double.TryParse(Console.ReadLine(), out taskAccuracyValue))
                {
                    if (taskAccuracyValue > 9 || taskAccuracyValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol9 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol9 = false; continue; }
                    else { return; }
                }
            }

            double taskPronunciationValue = 0;
            bool savol10 = false;
            while (!savol10)
            {
                savol10 = true;
                Console.Write(" Pronunciation: ");
                if (double.TryParse(Console.ReadLine(), out taskPronunciationValue))
                {
                    if (taskPronunciationValue > 9 || taskPronunciationValue < 0)
                    {
                        NotogriBahoKiritildi();
                        if (QaytaIshgaTushirishniAniqlash()) { savol10 = false; continue; }
                        else { return; }
                    }
                }
                else
                {
                    KlvFaqatRaqamKirit();
                    if (QaytaIshgaTushirishniAniqlash()) { savol10 = false; continue; }
                    else { return; }
                }
            }

            double speakingValue11 = 0;
            SpeakingBall(taskFluencyValue, taskResourceValue, taskAccuracyValue, taskPronunciationValue, ref speakingValue11);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($" SPEAKING yakuniy ball: {speakingValue11}");

            // ================= FINAL =================
            double ieltsValue1 = 0;
            IELTSBall(listeningValue1, readingValue1, writingValue11, speakingValue11, ref ieltsValue1);
            Console.WriteLine("\n==============================================================");
            Console.WriteLine($" IELTS YAKUNIY BALL: {ieltsValue1}");
            Console.WriteLine("==============================================================");
        }

        // LISTENING ballni xisoblash metodi
        static void ListeningBall(string listeningValue, ref double listeningValue1)
        {
            switch (listeningValue)
            {
                case "0": listeningValue1 = 0; break;
                case "1": listeningValue1 = 1; break;
                case "2": listeningValue1 = 1.5; break;
                case "3": listeningValue1 = 2; break;
                case "4":
                case "5": listeningValue1 = 2.5; break;
                case "6":
                case "7": listeningValue1 = 3; break;
                case "8":
                case "9": listeningValue1 = 3.5; break;
                case "10":
                case "11":
                case "12": listeningValue1 = 4; break;
                case "13":
                case "14":
                case "15": listeningValue1 = 4.5; break;
                case "16":
                case "17": listeningValue1 = 5; break;
                case "18":
                case "19":
                case "20":
                case "21":
                case "22": listeningValue1 = 5.5; break;
                case "23":
                case "24":
                case "25": listeningValue1 = 6; break;
                case "26":
                case "27":
                case "28":
                case "29": listeningValue1 = 6.5; break;
                case "30":
                case "31": listeningValue1 = 7; break;
                case "32":
                case "33":
                case "34": listeningValue1 = 7.5; break;
                case "35":
                case "36": listeningValue1 = 8; break;
                case "37":
                case "38": listeningValue1 = 8.5; break;
                case "39":
                case "40": listeningValue1 = 9; break;
                default:
                    {
                        NotogriTogriJavobKiritildi();
                        listeningValue1 = 10;
                        break;
                    }
            }
        }

        // READING ballni xisoblash metodi
        static void ReadingBall(string readingValue, ref double readingValue1)
        {
            switch (readingValue)
            {
                case "0": readingValue1 = 0; break;
                case "1": readingValue1 = 1; break;
                case "2": readingValue1 = 1.5; break;
                case "3": readingValue1 = 2; break;
                case "4":
                case "5": readingValue1 = 2.5; break;
                case "6":
                case "7": readingValue1 = 3; break;
                case "8":
                case "9": readingValue1 = 3.5; break;
                case "10":
                case "11":
                case "12": readingValue1 = 4; break;
                case "13":
                case "14": readingValue1 = 4.5; break;
                case "15":
                case "16":
                case "17":
                case "18": readingValue1 = 5; break;
                case "19":
                case "20":
                case "21":
                case "22": readingValue1 = 5.5; break;
                case "23":
                case "24":
                case "25":
                case "26": readingValue1 = 6; break;
                case "27":
                case "28":
                case "29": readingValue1 = 6.5; break;
                case "30":
                case "31":
                case "32": readingValue1 = 7; break;
                case "33":
                case "34": readingValue1 = 7.5; break;
                case "35":
                case "36": readingValue1 = 8; break;
                case "37":
                case "38": readingValue1 = 8.5; break;
                case "39":
                case "40": readingValue1 = 9; break;
                default:
                    {
                        NotogriTogriJavobKiritildi();
                        readingValue1 = 10;
                        break;
                    }
            }

        }


        // WRITING ballni xisoblash metodi
        static void WritingBall(double taskResponseValue, double taskCoherenceValue, double taskLexicalValue, double taskGrammarValue, ref double writingValue11)
        {
            double writingValue1 = Math.Round((taskResponseValue + taskCoherenceValue + taskLexicalValue + taskGrammarValue) / 4, 2);
            double writingValue1KasrQism = writingValue1 - Math.Floor(writingValue1);

            if (writingValue1KasrQism >= 0 && writingValue1KasrQism < 0.25)
            {
                writingValue11 = writingValue1 - writingValue1KasrQism;
            }
            else if (writingValue1KasrQism >= 0.25 && writingValue1KasrQism < 0.75)
            {
                writingValue11 = writingValue1 - writingValue1KasrQism + 0.5;
            }
            else if (writingValue1KasrQism >= 0.75 && writingValue1KasrQism < 1)
            {
                writingValue11 = writingValue1 - writingValue1KasrQism + 1;
            }
        }


        // SPEAKING ballni xisoblash metodi
        static void SpeakingBall(double taskFluencyValue, double taskResourceValue, double taskAccuracyValue, double taskPronunciationValue, ref double speakingValue11)
        {
            double speakingValue1 = Math.Round((taskFluencyValue + taskResourceValue + taskAccuracyValue + taskPronunciationValue) / 4, 2);
            double speakingValue1KasrQism = speakingValue1 - Math.Floor(speakingValue1);
            if (speakingValue1KasrQism >= 0 && speakingValue1KasrQism < 0.25)
            {
                speakingValue11 = speakingValue1 - speakingValue1KasrQism;
            }
            else if (speakingValue1KasrQism >= 0.25 && speakingValue1KasrQism < 0.75)
            {
                speakingValue11 = speakingValue1 - speakingValue1KasrQism + 0.5;
            }
            else if (speakingValue1KasrQism >= 0.75 && speakingValue1KasrQism < 1)
            {
                speakingValue11 = speakingValue1 - speakingValue1KasrQism + 1;
            }
        }


        // Yakuniy ballni xisoblash metodi
        static void IELTSBall(double listeningValue1, double readingValue1, double writingValue11, double speakingValue11, ref double ieltsValue1)
        {
            double ieltsValue = Math.Round((listeningValue1 + readingValue1 + writingValue11 + speakingValue11) / 4, 2);
            double ieltsValueKasrQism = ieltsValue - Math.Floor(ieltsValue);
            if (ieltsValueKasrQism >= 0 && ieltsValueKasrQism < 0.25)
            {
                ieltsValue1 = ieltsValue - ieltsValueKasrQism;
            }
            else if (ieltsValueKasrQism >= 0.25 && ieltsValueKasrQism < 0.75)
            {
                ieltsValue1 = ieltsValue - ieltsValueKasrQism + 0.5;
            }
            else if (ieltsValueKasrQism >= 0.75 && ieltsValueKasrQism < 1)
            {
                ieltsValue1 = ieltsValue - ieltsValueKasrQism + 1;
            }
        }


        // klaviaturdan faqat raqam kiritish haqida ogohlantirish metodi
        static void KlvFaqatRaqamKirit()
        {
            Console.WriteLine("\n Klaviaturadan faqat raqam kiritish lozim !");
        }

        // Notog'ri baho kiritilganida ogohlantirish metodi
        static void NotogriBahoKiritildi()
        {
            Console.WriteLine("\n Bunday miqdorda baho olish imkonsiz !");
        }

        // Tog'ri javoblar soni notog'ri kiritilganida ogohlantirish metodi
        static void NotogriTogriJavobKiritildi()
        {
            Console.WriteLine("\n Bunday miqdorda to'g'ri javob berish imkonsiz !");
        }

        // 40 ta savoldan nechtasiga togri javob berganini sorash uchun console yozuvi
        static void Savol40taNechtasigaTogriJavobBerdingiz()
        {
            Console.Write(" 40 ta savoldan nechtasiga to'g'ri javob berganizni kiriting (0 <= Tog'ri javob <= 40): ");
        }

        // Quyidagi tasklardan olgan baholarini sorash uchun console yozuvi
        static void QuyidagiTasklardanOlinganBaholarniKiritish()
        {
            Console.WriteLine(" \n Quyidagi Task (vazifa)larga qo'yilgan baholarni kiriting (0 <= baho <= 9)");
        }

        // Qayta ishga tushirishni aniqlash metodi

        static bool QaytaIshgaTushirishniAniqlash()
        {
            Console.Write(" Dasturni qayta ishga tushirishni istaysizmi ? (yes/no):");
            return Console.ReadLine().ToLower() == "yes";
        }
    }
}
