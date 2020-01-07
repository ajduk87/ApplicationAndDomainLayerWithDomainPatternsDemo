﻿using CommercialApplication.DomainLayer.Repositories.Commands.OrderCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialApplication.DomainLayer.Repositories.Commands.Callers
{
    public class CommandOrderCaller
    {
        public Dictionary<string, IOrderCommand> DictCommands { get; set; }
        public CommandOrderCaller()
        {
            DictCommands = new Dictionary<string, IOrderCommand>();
            //OrderItem
            DictCommands.Add("DeleteOrderItemById", new DeleteOrderItemByIdCommand());
            DictCommands.Add("DeleteOrderItemByIds", new DeleteOrderItemByIdsCommand());
            DictCommands.Add("GetOrderItemById", new GetOrderItemByIdCommand());
            DictCommands.Add("GetOrderItemByIds", new GetOrderItemByIdsCommand());
            DictCommands.Add("IncludeDiscountForPaying", new IncludeDiscountForPayingCommand());
            DictCommands.Add("InsertListOrderItem", new InsertListOrderItemCommand());
            DictCommands.Add("InsertOrderItem", new InsertOrderItemCommand());
            DictCommands.Add("UpdateListOrderItem", new UpdateListOrderItemCommand());
            DictCommands.Add("UpdateOrderItem", new UpdateOrderItemCommand());
        }
    }
}
