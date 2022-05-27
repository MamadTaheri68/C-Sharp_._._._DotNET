﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Application.Contracts.Product
{
    public interface IProductApplication
    {
        void Create(CreateProduct command);
        void Edit(EditProduct command);
        void Remove(int id);
        void REstore(int id);
        EditProduct GetDetails(int id);
        List<ProductViewModel> Search(ProductSearchModel searchModel);
    }
}
