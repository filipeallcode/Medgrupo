namespace Contacts.Validations
{
    public class ContactAgeValidation
    {
        public bool IsLegalAge(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }

            return false;
        }
    }
}