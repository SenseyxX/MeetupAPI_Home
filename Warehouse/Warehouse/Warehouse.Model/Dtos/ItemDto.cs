﻿using System;
using Warehouse.Persistence.Entities;
using Warehouse.Persistence.Entities.Item;
using Warehouse.Persistence.Entities.Item.Entities;

namespace Warehouse.Model.Dtos
{
      public class ItemDto // Klasa która ma za zadanie odizolować wybrane propy od głownej encj
      {
            protected ItemDto(
                      Guid id,
                      string name,
                      string description,
                      Guid categoryId,
                      QualityLevel qualityLevel,
                      int quantity,
                      State state,
                      Guid? ownerId,
                      Guid actualOwnerId)
            {
                  Id = id;
                  Name = name;
                  Description = description;
                  CategoryId = categoryId;
                  QualityLevel = qualityLevel;
                  Quantity = quantity;
                  State = state;
                  OwnerId = ownerId;
                  ActualOwnerId = actualOwnerId;
            }

            public Guid Id { get; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Guid CategoryId { get; set; }
            public QualityLevel QualityLevel { get; set; }
            public int Quantity { get; set; }
            public State State { get; set; }
            public Guid? OwnerId { get; set; }
            public Guid ActualOwnerId { get; set; }

		  public static explicit operator ItemDto(Item item)
                => new ItemDto(
                        item.Id,
                        item.Name,
                        item.Description,
                        item.CategoryId,
                        item.QualityLevel,
                        item.Quantity,
                        item.State,
                        item.OwnerId,
                        item.ActualOwnerId);
    }
}
