

using MediatorDP;
using MediatorDP.Modules;

var applicationMediator = new ApplicationMediator();

applicationMediator.RegisterModule(new OrderModule(applicationMediator));
applicationMediator.RegisterModule(new PaymentModule(applicationMediator));
applicationMediator.RegisterModule(new StockModule(applicationMediator));

var orderModule = new OrderModule(applicationMediator);

orderModule.CreateOrder("Order Details: Product A, Quantity: 2");