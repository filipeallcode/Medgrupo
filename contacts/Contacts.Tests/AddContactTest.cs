using System;
using Xunit;
using Contacts.Validations;

namespace Contacts.Tests
{
    public class AddContactTest
    {
        [Fact]
        public void IsLegalAge_InputIs17_ReturnFalse()
        {
            var contact = new ContactAgeValidation();
            bool result = contact.IsLegalAge(17);

            Assert.False(result, "Cadastro de contato com idade abaixo de 18 anos não deve ser permitido.");
        }
    }
}
