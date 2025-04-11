﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    interface IProductRepository
    {
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int id);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);


    }
}
