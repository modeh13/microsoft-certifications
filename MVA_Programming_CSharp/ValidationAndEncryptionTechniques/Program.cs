using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ValidationAndEncryptionTechniques.Classes;

namespace ValidationAndEncryptionTechniques
{
   class Program
   {
      public class Animal { }
      public class Dog : Animal { }
      public class Cat : Animal { }

      static void Main(string[] args)
      {
         WorkingWithValidationDataContracts();
         WorkingWithEncryption();
      }

      private static void PrintTitle(string title)
      {
         Console.WriteLine(new string('-', 50));
         Console.WriteLine(title);
         Console.WriteLine(new string('-', 50));
      }

      /// <summary>
      /// Working with Validation
      /// Using the operator "is"
      /// </summary>
      private static void WorkingWithValidation()
      {
         PrintTitle("Working with Type Validation");

         Animal dog = new Dog();
         Animal cat = new Cat();

         if (cat is Dog)
            throw new NotSupportedException("Dogs only");

         //Compares the "object references" If two objects you are comparing are referring to the same exact instance of an object.
         if (cat == dog)
            throw new Exception("Not the same");

         //if one has the same content and came from a different source (is a separate instance with the same data), Equals return true.
         if (cat.Equals(dog))
            throw new Exception("Not Equal");
      }

      /// <summary>
      /// Working with Validation
      /// Implementing the "Data Contracts"
      /// </summary>
      private static void WorkingWithValidationDataContracts()
      {
         PrintTitle("Working with Validation using Data Contracts");
         Employee employee = new Employee();
         employee.SetNameWithDataContract("" +
            "");
      }

      /// <summary>
      /// To be able to work with "Data protection", we need to add a reference,
      /// we need to add the "System.Securty.dll"
      /// 
      /// Encryption: There're four different Types.
      /// - File Encryption
      /// Encrypts and decrypts files
      /// Fast to encrypt/decrypt, 
      /// Based on user credentials
      /// 
      /// - Windows Data protection (Based on user credentials)
      /// Encrypts and decrypts byte[]
      /// Fast to encrypt/decrypt
      /// Based on user credentials
      /// 
      /// - Hashing, used for signing and validation
      /// One-way encryption
      /// 
      /// Common algorithms:
      /// MD5 (16 character hash, it can be stored in a GUID)
      /// SHA (SHA1, SHA256, SHA384, SHA512)
      /// 
      /// Fast (Depending on chosen algorithm)
      /// 
      /// 
      /// - Symmetric and Asymmetric
      /// Symmetric: One key is used for both encryption and decryption.
      /// Faster than asymmetric encryption
      /// Algorithms:
      /// AES (Recommended)
      /// DES
      /// RC2
      /// Rijndael
      /// TripleDES
      /// 
      /// Asymmetric: One key is used for encryption (Public) and another key
      /// for decryption (Private).
      /// Commonly used for digital signatures.
      /// Algorithms:
      /// DSA
      /// ECDiffieHellman
      /// ECDsa
      /// RSA (Most popular)
      /// </summary>
      private static void WorkingWithEncryption()
      {
         PrintTitle("Working with Encryption");

         const string dataToEncrypt = "This is an important data to keep safe, for this reason, we must encrypt into file.";
         byte[] dataArray = Encoding.Unicode.GetBytes(dataToEncrypt);

         //File Encryption
         #region File Encryption                  
         string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDataFile.txt");
         File.WriteAllBytes(fileName, dataArray);
         File.Encrypt(fileName);
         #endregion

         //Windows Data protection
         #region Windows Data Protection
         byte[] wdpEncryptedData = ProtectedData.Protect(dataArray, null, DataProtectionScope.CurrentUser);
         byte[] wdpDecryptedData = ProtectedData.Unprotect(wdpEncryptedData, null, DataProtectionScope.CurrentUser);
         string wdpUnencryptString = Encoding.Unicode.GetString(wdpDecryptedData);

         Debug.Assert(dataToEncrypt.Equals(wdpUnencryptString));
         #endregion

         //Hashing
         #region Hashing
         //This is a previous BYTE array of the Hash for the password "P4ssw0rd".
         byte[] storedPasswordHash = new byte[]
            {
            148, 152, 235, 251, 242, 51, 18, 100, 176, 51, 147,
            249, 128, 175, 164, 106, 204, 48, 47, 154, 75,
            82, 83, 170, 111, 8, 107, 51, 13, 83, 2, 252
            };

         byte[] password = Encoding.Unicode.GetBytes("P4ssw0rd!");
         byte[] passwordHash = SHA256.Create().ComputeHash(password);

         if (passwordHash.SequenceEqual(storedPasswordHash))
         {
            Console.WriteLine("Passwords match !!");
         }
         #endregion

         //Symmetric

         #region Symmetric
         //Array of 16 random bytes - Must be used for Decryption
         //Should be secret
         byte[] key = new byte[]
         {
            12, 2, 56, 117, 12, 67, 33, 23, 12, 2, 56, 117, 12, 67, 33, 23
         };

         //Another list of 16 bytes - Can be shared publically,
         //Should be changed for each message exchange 
         byte[] initialzationVector = new byte[]
         {
            37, 99, 102, 23, 12, 22, 156, 204, 11, 12, 23, 44, 55, 1, 157, 233
         };

         byte[] symEncryptedData;

         //Save for reuse
         Aes algorithm = Aes.Create();

         //Encrypt
         using (var encryptor = algorithm.CreateEncryptor(key, initialzationVector))
         using (var memoryStream = new MemoryStream())
         using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
         {
            cryptoStream.Write(dataArray, 0, dataArray.Length);
            cryptoStream.FlushFinalBlock();
            symEncryptedData = memoryStream.ToArray();
         }

         //Decrypt
         byte[] symUnencrypedData;
         using (var decryptor = algorithm.CreateDecryptor(key, initialzationVector))
         using (var memoryStream = new MemoryStream())
         using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
         {
            cryptoStream.Write(symEncryptedData, 0, symEncryptedData.Length);
            cryptoStream.FlushFinalBlock();
            symUnencrypedData = memoryStream.ToArray();
         }

         algorithm.Dispose();

         if (dataArray.SequenceEqual(symUnencrypedData))
         {
            Console.WriteLine("Symmetric encrypted values match!.");
         }
         #endregion

         #region Asymmetric

         byte[] signature;
         byte[] publicAndPrivateKey;
         byte[] publicKeyOnly;
         var hashImplementation = SHA1.Create();

         //Create a signature, create our public and private keys - we could save these out as XML, etc.
         using (var rsaProvider = new RSACryptoServiceProvider())
         {
            signature = rsaProvider.SignData(dataArray, hashImplementation);
            publicAndPrivateKey = rsaProvider.ExportCspBlob(true);
            publicKeyOnly = rsaProvider.ExportCspBlob(false);
         }

         //Create a new RSA
         using (var rsaProvider = new RSACryptoServiceProvider())
         {
            //Import our public key
            rsaProvider.ImportCspBlob(publicKeyOnly);

            //Has it been tampered with?
            if (!rsaProvider.VerifyData(dataArray, hashImplementation, signature))
            {
               Console.WriteLine("Data has been tampered with");
            }

            //Now let's tamper with our data

            dataArray[5] = 255;
            if (!rsaProvider.VerifyData(dataArray, hashImplementation, signature))
            {
               Console.WriteLine("Data has been tampered with");
            }
         }

         hashImplementation.Dispose();

         #endregion
      }

      #region Windows Data Protection
      public static void EncryptInMemoryData(byte[] Buffer, MemoryProtectionScope Scope)
      {
         if (Buffer == null)
            throw new ArgumentNullException("Buffer");
         if (Buffer.Length <= 0)
            throw new ArgumentException("Buffer");


         // Encrypt the data in memory. The result is stored in the same array as the original data.
         ProtectedMemory.Protect(Buffer, Scope);
      }

      public static void DecryptInMemoryData(byte[] Buffer, MemoryProtectionScope Scope)
      {
         if (Buffer == null)
            throw new ArgumentNullException("Buffer");
         if (Buffer.Length <= 0)
            throw new ArgumentException("Buffer");


         // Decrypt the data in memory. The result is stored in the same array as the original data.
         ProtectedMemory.Unprotect(Buffer, Scope);
      }

      public static byte[] CreateRandomEntropy()
      {
         // Create a byte array to hold the random value.
         byte[] entropy = new byte[16];

         // Create a new instance of the RNGCryptoServiceProvider.
         // Fill the array with a random value.
         new RNGCryptoServiceProvider().GetBytes(entropy);

         // Return the array.
         return entropy;
      }

      public static int EncryptDataToStream(byte[] Buffer, byte[] Entropy, DataProtectionScope Scope, Stream S)
      {
         if (Buffer == null)
            throw new ArgumentNullException("Buffer");
         if (Buffer.Length <= 0)
            throw new ArgumentException("Buffer");
         if (Entropy == null)
            throw new ArgumentNullException("Entropy");
         if (Entropy.Length <= 0)
            throw new ArgumentException("Entropy");
         if (S == null)
            throw new ArgumentNullException("S");

         int length = 0;

         // Encrypt the data in memory. The result is stored in the same array as the original data.
         byte[] encryptedData = ProtectedData.Protect(Buffer, Entropy, Scope);

         // Write the encrypted data to a stream.
         if (S.CanWrite && encryptedData != null)
         {
            S.Write(encryptedData, 0, encryptedData.Length);

            length = encryptedData.Length;
         }

         // Return the length that was written to the stream. 
         return length;
      }

      public static byte[] DecryptDataFromStream(byte[] Entropy, DataProtectionScope Scope, Stream S, int Length)
      {
         if (S == null)
            throw new ArgumentNullException("S");
         if (Length <= 0)
            throw new ArgumentException("Length");
         if (Entropy == null)
            throw new ArgumentNullException("Entropy");
         if (Entropy.Length <= 0)
            throw new ArgumentException("Entropy");

         byte[] inBuffer = new byte[Length];
         byte[] outBuffer;

         // Read the encrypted data from a stream.
         if (S.CanRead)
         {
            S.Read(inBuffer, 0, Length);

            outBuffer = ProtectedData.Unprotect(inBuffer, Entropy, Scope);
         }
         else
         {
            throw new IOException("Could not read the stream.");
         }

         // Return the length that was written to the stream. 
         return outBuffer;
      } 
      #endregion
   }
}