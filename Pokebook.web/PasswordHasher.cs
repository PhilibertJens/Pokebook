﻿using Microsoft.AspNetCore.Identity;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Pokebook.web
{
    public class PasswordHasher : IPasswordHasher<User>
    {
        public string HashPassword(User user, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);//16 random values as salt

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);//hashing algorithm hashes 1000 times
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36]; //20hash + 16salt bytes (fixed)
            //prepend salt in front of hash
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashedPass = Convert.ToBase64String(hashBytes);
            user.PasswordHash = hashedPass;
            return hashedPass;
        }

        public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
        {
            byte[] hashedBytes = Convert.FromBase64String(user.PasswordHash);
            byte[] salt = new byte[16];
            Array.Copy(hashedBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(providedPassword, salt, 1000);//hash input with same algorithm as encrypted
            byte[] hash = pbkdf2.GetBytes(20);

            bool flag = true;
            for (int i = 0; i < 20; i++)
            {
                if (hashedBytes[i + 16] != hash[i])
                {
                    flag = false;
                }
            }

            return (flag) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        }
    }
}
