﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IContacts
{
    public interface IProductManager
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<bool> Add(Product product);
        Task<bool> Update(Product product);
        Task<bool> Remove(int id);
    }
}
