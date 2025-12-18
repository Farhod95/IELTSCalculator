namespace IELTSCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n  ***   IELTS ballarini hisoblash kalkulyatori   *** \n");

            // LISTENING ballni xisoblash
            Console.WriteLine(" LISTENING (Tinglab tushunish) ");
            Savol40taNechtasigaTogriJavobBerdingiz();
            double listeningValue1 = 0;

            if (double.TryParse(Console.ReadLine(), out double listeningValue))
            {
                ListeningBall(listeningValue, ref listeningValue1);
                Console.WriteLine($"  \n LISTENING (Tinglab tushunish) dan olgan yakuniy ballingiz: {listeningValue1}");
            }
            else { KlvFaqatRaqamKirit(); return; }            


            // READING ballni xisoblash
            Console.WriteLine(" \n \n READING (O‘qish) ");
            Savol40taNechtasigaTogriJavobBerdingiz();
            double readingValue1 = 0;

            if (double.TryParse(Console.ReadLine(), out double readingValue))
            {
                ReadingBall(readingValue, ref readingValue1);
                Console.WriteLine($"  \n READING (O‘qish) dan olgan yakuniy ballingiz: {readingValue1}");
            }
            else { KlvFaqatRaqamKirit(); return; }            


            // WRITING ballni xisoblash
            Console.WriteLine(" \n \n WRITING (Yozish) ");
            QuyidagiTasklardanOlinganBaholarniKiritish();

            Console.Write("   -Task Response -> Vazifaga javob berish: ");
            if (double.TryParse(Console.ReadLine(), out double taskResponseValue))
            {
                if (taskResponseValue > 9 || taskResponseValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Coherence/Cohesion -> Mantiqiylik va bog‘liqlik: ");
            if (double.TryParse(Console.ReadLine(), out double taskCoherenceValue))
            {
                if (taskCoherenceValue > 9 || taskCoherenceValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Lexical Resource -> Leksik boylik (so‘z boyligi): ");
            if (double.TryParse(Console.ReadLine(), out double taskLexicalValue))
            {
                if (taskLexicalValue > 9 || taskLexicalValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Grammar -> Gramatika: ");
            if (double.TryParse(Console.ReadLine(), out double taskGrammarValue))
            {
                if (taskGrammarValue > 9 || taskGrammarValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }
            double writingValue11 = 0;

            WritingBall(taskResponseValue, taskCoherenceValue, taskLexicalValue, taskGrammarValue, ref writingValue11);  
            Console.WriteLine($" \n \n WRITING (Yozish) dan olgan yakuniy ballingiz: {writingValue11}");


            // SPEAKING ballni xisoblash
            Console.WriteLine(" \n \n SPEAKING (GAPIRISH) ");
            QuyidagiTasklardanOlinganBaholarniKiritish();

            Console.Write("   -Fluency and Coherence -> Ravonlik va mantiq: ");
            if (double.TryParse(Console.ReadLine(), out double taskFluencyValue))
            {
                if (taskFluencyValue > 9 || taskFluencyValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Lexical Resource -> So‘z boyligi: ");
            if (double.TryParse(Console.ReadLine(), out double taskResourceValue))
            {
                if (taskResourceValue > 9 || taskResourceValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Grammatical Range and Accuracy -> Grammatika: ");
            if (double.TryParse(Console.ReadLine(), out double taskAccuracyValue))
            {
                if (taskAccuracyValue > 9 || taskAccuracyValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }

            Console.Write("   -Pronunciation -> Talaffuz: ");
            if (double.TryParse(Console.ReadLine(), out double taskPronunciationValue))
            {
                if (taskPronunciationValue > 9 || taskPronunciationValue < 0) { NotogriBahoKiritildi(); return; }
            }
            else { KlvFaqatRaqamKirit(); return; }
            double speakingValue11 = 0;

            SpeakingBall(taskFluencyValue, taskResourceValue, taskAccuracyValue, taskPronunciationValue, ref speakingValue11);  // Metod      
            Console.WriteLine($" \n \n SPEAKING (Gapirish) dan olgan yakuniy ballingiz: {speakingValue11}");


            // Yakuniy ballni hisoblash
            double ieltsValue1 = 0;
            IELTSBall(listeningValue1, readingValue1, writingValue11, speakingValue11, ref ieltsValue1);    
            Console.WriteLine($" \n \n **** IELTS dan olgan yakuniy ballingiz: {ieltsValue1}   ****");
        }

        // LISTENING ballni xisoblash metodi
        static void ListeningBall(double listeningValue, ref double listeningValue1)
        {
            switch (listeningValue)
            {
                case 0: listeningValue1 = 0; break;
                case 1: listeningValue1 = 1; break;
                case 2: listeningValue1 = 1.5; break;
                case 3: listeningValue1 = 2; break;
                case 4:
                case 5: listeningValue1 = 2.5; break;
                case 6:
                case 7: listeningValue1 = 3; break;
                case 8:
                case 9: listeningValue1 = 3.5; break;
                case 10:
                case 11:
                case 12: listeningValue1 = 4; break;
                case 13:
                case 14:
                case 15: listeningValue1 = 4.5; break;
                case 16:
                case 17: listeningValue1 = 5; break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: listeningValue1 = 5.5; break;
                case 23:
                case 24:
                case 25: listeningValue1 = 6; break;
                case 26:
                case 27:
                case 28:
                case 29: listeningValue1 = 6.5; break;
                case 30:
                case 31: listeningValue1 = 7; break;
                case 32:
                case 33:
                case 34: listeningValue1 = 7.5; break;
                case 35:
                case 36: listeningValue1 = 8; break;
                case 37:
                case 38: listeningValue1 = 8.5; break;
                case 39:
                case 40: listeningValue1 = 9; break;
                default: NotogriTogriJavobKiritildi(); break;
            }
        }


        // READING ballni xisoblash metodi
        static void ReadingBall(double readingValue, ref double readingValue1)
        {
            switch (readingValue)
            {
                case 0: readingValue1 = 0; break;
                case 1: readingValue1 = 1; break;
                case 2: readingValue1 = 1.5; break;
                case 3: readingValue1 = 2; break;
                case 4:
                case 5: readingValue1 = 2.5; break;
                case 6:
                case 7: readingValue1 = 3; break;
                case 8:
                case 9: readingValue1 = 3.5; break;
                case 10:
                case 11:
                case 12: readingValue1 = 4; break;
                case 13:
                case 14: readingValue1 = 4.5; break;
                case 15:
                case 16:
                case 17:
                case 18: readingValue1 = 5; break;
                case 19:
                case 20:
                case 21:
                case 22: readingValue1 = 5.5; break;
                case 23:
                case 24:
                case 25:
                case 26: readingValue1 = 6; break;
                case 27:
                case 28:
                case 29: readingValue1 = 6.5; break;
                case 30:
                case 31:
                case 32: readingValue1 = 7; break;
                case 33:
                case 34: readingValue1 = 7.5; break;
                case 35:
                case 36: readingValue1 = 8; break;
                case 37:
                case 38: readingValue1 = 8.5; break;
                case 39:
                case 40: readingValue1 = 9; break;
                default: NotogriTogriJavobKiritildi(); break;
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
    }
}
