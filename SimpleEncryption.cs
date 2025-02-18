namespace SimpleEncryption
{
    internal class SimpleEncryption
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you wish to encrypt or decrypt? Please type 1 for encrypting or 2 for decrypting: \n");
                String response = Console.ReadLine()!;
                if (!response.Equals("1") && !response.Equals("2"))
                    Console.WriteLine("Sorry, that's not a valid response, please type 1 or 2: \n");
                if (response.Equals("1"))
                {
                    //Encryption time:
                    Console.WriteLine("Please enter the text you wish to encrypt: \n");
                    response = Console.ReadLine()!;
                    Console.WriteLine("Encrypted Text: \n" + EncryptText(response) + '\n');
                }
                else
                {
                    if (response.Equals("2"))
                    {
                        //Decryption time:
                        Console.WriteLine("Please enter the text you wish to decrypt: \n");
                        response = Console.ReadLine()!;
                        Console.WriteLine("Encrypted Text: \n" + DecryptText(response) + '\n');
                    }
                }
                Console.WriteLine("Restart? (Type Y to restart or anything else to end): \n");
                response = Console.ReadLine()!;
                if (response.Equals("Y"))
                {
                    continue;
                }
                break;
                
            }

        }

        /// <summary>
        /// Encrypts given text to be unreadable to anyone who doesn't know how to decrypt.
        /// However, it is not a very good encryption and most likely isn't the safest for actual use.
        /// </summary>
        private static string EncryptText(String text)
        {
            Random r = new Random();
            char[] chars = new char[10] { 'a', 't', 'k', 'l', 'w', 'q', 'p', 'P', 'A', 'T' };
            string encryptedText = "";
            for (int i = text.Length - 1; i >= 1; i -= 2)
            {
                encryptedText += text[i - 1];
                encryptedText += text[i];
                encryptedText += chars[r.Next(9)];
            }

            return encryptedText;
        }

        /// <summary>
        /// Decrypts the text given that was specifically encrypted with the Encryption method above.
        /// </summary>
        private static string DecryptText(String text)
        {
            string decryptedText = "";
            while (text.Length > 0)
            {
                decryptedText += text[text.Length - 3];
                decryptedText += text[text.Length - 2];
                text = text.Substring(0, text.Length - 3);
            }

            return decryptedText;
        }
    }
}
