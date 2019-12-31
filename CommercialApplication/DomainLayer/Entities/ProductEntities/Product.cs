﻿using CommercialApplicationCommand.DomainLayer.Entities.ValueObjects.Common;
using CommercialApplicationCommand.DomainLayer.Entities.ValueObjects.Product;

namespace CommercialApplicationCommand.DomainLayer.Entities.ProductEntities
{
    public class Product : Entity
    {
        public Name Name { get; set; }
        public UnitCost UnitCost { get; set; }
        public Description Description { get; set; }
        public ImageUrl ImageUrl { get; set; }
        public VideoLink VideoLink { get; set; }
        public SerialNumber SerialNumber { get; set; }
    }
}