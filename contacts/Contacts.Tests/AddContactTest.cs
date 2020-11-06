using System;
using Xunit;
using ContactViewModel;

namespace Contacts.Tests
{
    public class AddContactTest
    {
        [Fact]
        public void IsLegalAge_InputIs17_ReturnFalse()
        {
            int contact = new ContactViewModel();
            bool result = contact.IsLegalAge(17);

            Assert.False(result, "Cadastro de contato com idade abaixo de 18 anos não deve ser permitido.")
        }
    }
}
