using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelVelidationExample.Models;

namespace ModelVelidationExample.CustomModelBinders
{
    public class PersonModelBinder : IModelBinder
    {
        Person person = new Person();
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //FirstName and lastname
            if (bindingContext.ValueProvider.GetValue("FirstName").Length > 0) {

                person.PersonName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;
                if (bindingContext.ValueProvider.GetValue("LastName").Length > 0)
                {

                    person.PersonName +=" "+ bindingContext.ValueProvider.GetValue("LastName").FirstValue;
                }

            }
            //Email
            if (bindingContext.ValueProvider.GetValue("Email").Length > 0)
            {
                person.Email = bindingContext.ValueProvider.GetValue("Email").FirstValue;
            }
            bindingContext.Result = ModelBindingResult.Success(person);
            return Task.CompletedTask;
        }
    }
}
