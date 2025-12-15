
using FacadeDP.FacadeOrder;

var orderFacade = new OrderFacadeProcess();

orderFacade.PlaceOrder(
    productName: "Laptop",
    quantity: 1,
    amount: 1500.00,
    paymentType: "Credit Card",
    shipmentType: "Express",
    address: "123 Main St, Anytown, USA"
);