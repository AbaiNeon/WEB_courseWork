static void Main(string[] args)
        {
            string text = @"Только представьте, что обладая навыком скорочтения. Ваши мозги по мановению волшебной палочки включается на полную мощность! Вы слышите голос автора.Слова высвечиваются ярко и выпукло.В голове появляется легкий ветерок в от осознания новых возможностей. Вы разбираете завалы книг. Учебники, инструкции, документация – все это оказывается в месте, где вы храните прочитанные книги. Вы быстро читаете.Вы в восторге от того, что дело, которое, так долго откладывали, оказалось легким и простым. Скорочтение - мечта или реальность?";

            Do(text);


        }

        //первая, вторая и посл буква остаются
        //через каждое третье слово
        static void Do(string text)
        {
            List<string> words = text.Split(" ,.!?-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (i%2 != 0)
                {
                    words[i] = ShuffleWord(words[i]);
                }
                
            }
        }

        static public string ShuffleWord(string word)
        {
            char[] array = word.ToCharArray();
            Random rng = new Random();
            int n = array.Length-1;
            while (n > 1)
            {

                int k = rng.Next(2, n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
                n--;
            }
            return new string(array);
        }
