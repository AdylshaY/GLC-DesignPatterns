using HasAIsA.GoodExample.Interfaces;
using HasAIsA.GoodExample.PlaneBehavior;
using Good = HasAIsA.GoodExample;

//Bad.Vehicle vehicle = new Bad.Car();

//vehicle.Forward();
//vehicle.Left();
//vehicle.Right();
//vehicle.Backward();

//Console.WriteLine(new string('-', 30));

//vehicle = new Bad.SuperCar();
//vehicle.Forward();
//vehicle.Left();
//vehicle.Right();
//vehicle.Backward();


Good.Vehicle goodVehicle = new Good.CarVehicle();

goodVehicle.Forward();
((ILeftOrRightBehavior)goodVehicle).Left();
((ILeftOrRightBehavior)goodVehicle).Right();
goodVehicle.Backward();
goodVehicle.Stop();

goodVehicle = new Good.Plane();
goodVehicle.Forward();
goodVehicle.ChangeForwardBehavior(new PlaneForwardBehavior());
goodVehicle.Forward();
goodVehicle.Backward();
goodVehicle.Stop();

