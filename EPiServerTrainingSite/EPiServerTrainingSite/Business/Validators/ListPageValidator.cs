
using System.Collections.Generic;
using EPiServer.Core;
using EPiServer.Validation;
using EPiServerTrainingSite.Models.Pages;

namespace EPiServerTrainingSite.Business.Validators
{
    public class ListPageValidator : IValidate<ListPage>
    {
        public IEnumerable<ValidationError> Validate(ListPage page)
        {
            if (page.NumberOfItems > 0 && ContentReference.IsNullOrEmpty(page.ListRootPage))
            {
                yield return new ValidationError()
                {
                    PropertyName = "List root page",
                    ErrorMessage = "List root page must have a value if number of items is greater than zero"
                };
            }
        }
    }
}