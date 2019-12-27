﻿using System.Collections.Generic;

namespace CommercialApplicationCommand.ApplicationLayer.Dtoes.Order
{
    public class OrderDto : Dto
    {
        public long CommercialistId { get; set; }
        public long CustomerId { get; set; }
        public IEnumerable<OrderItemDto> orderItems { get; set; }
    }
}