﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.DataAccess.Repository.IRepository
{
  public interface IOrderDetailRepository: IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);

    }
}
