using System;

namespace ValidationNamespace
{
    class Validation
    {
        public void isUsernameValid(string username)
        {
            if (username.Length < 3) throw new Exception("Username must be at least 3 characters long");
        }
        public void isPasswordValid(string password)
        {
            if (password.Length < 3) throw new Exception("Password must be at least 3 characters long");
        }
        public void isNameValid(string name)
        {
            if (name.Length < 3)
            {
                throw new Exception("Name must be at least 3 characters long");
            }
        }

        public void isChoiceValid(string choice)
        {
            if (!choice.All(char.IsDigit)) 
            {
                throw new Exception("Choice must be a number");
            }
        }

        public void isAgeValid(string age)
        {
            if (!age.All(char.IsDigit))
            {
                throw new Exception("Age must be a number");
            }
            if (int.Parse(age) < 18)
            {
                throw new Exception("Age must be at least 18");
            }
        }
        public void isContributionValid(string contribution)
        {
            if (!contribution.All(char.IsDigit))
            {
                throw new Exception("Contribution must be a number");
            }
            if (int.Parse(contribution) < 0)
            {
                throw new Exception("Contribution must be at least 0");
            }
        }
        public void isParticipatingValid(string participating)
        {
            if (!(participating.ToLower() == "yes" || participating.ToLower() == "no"))
            {
                throw new Exception("Participating must be yes or no");
            }
        }
    }
}