﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

internal interface IBl
{

public IOrder Order { get;  }
public IOrderItem OrderItem { get; }    
public IProduct Product { get; }


}
