using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindMVC.Models
{
    public class CustomerIdsViewModel
    {
       
         public int Id { get; set; }

        public readonly List<SelectListItem> CustomerIdSelectedList;

        public CustomerIdsViewModel(List<int> CustomerIds)

        {

            CustomerIdSelectedList = new List<SelectListItem>();

            foreach (int Id in CustomerIds)

            {

                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{Id}", Value = $"{Id}" });

            }

        }
    }
}
