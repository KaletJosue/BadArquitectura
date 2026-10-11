using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Domain.Services;

using Domain.Entities;

public static class OrderService
{
    private static readonly List<Order> _lastOrders = new List<Order>();
    public static IReadOnlyList<Order> LastOrders { get; } = _lastOrders.AsReadOnly();

    public static Order CreateTerribleOrder(string customer, string product, int qty, decimal price)
    {
        var o = new Order
        {
            Id = RandomNumberGenerator.GetInt32(1, 9999999),
            CustomerName = customer,
            ProductName = product,
            Quantity = qty,
            UnitPrice = price
        };

        _lastOrders.Add(o);

        Infrastructure.Logging.Logger.Log("Created order " + o.Id + " for " + customer);

        return o;
    }
}
