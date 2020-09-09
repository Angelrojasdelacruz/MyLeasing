using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        public IEnumerable<SelectListItem> GetComboLessees()
        {
            throw new System.NotImplementedException();
        }

        public  IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            var list = dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"


            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a Property  Type...)",
                Value = "0"

            });


            return list;
        }

    }
}

