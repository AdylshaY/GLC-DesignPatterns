
#region Example 1

// Client => Invoker => ICommand => ConcreteCommand => Receiver

//using CommandDP.Example1.Commands;
//using CommandDP.Example1.Invokers;
//using CommandDP.Example1.Receivers;

//var lightReceiver = new LightReceiverProcess();
//var remoteControl = new RemoteControl();

//Console.WriteLine("=== Tekli Komut Testleri ===");
//// Turn light on
//remoteControl.SetCommand(new LightOn(lightReceiver));
//remoteControl.PressButton();

//// Turn light off
//remoteControl.SetCommand(new LightOff(lightReceiver));
//remoteControl.PressButton();

//// Undo last command (should turn light on again)
//remoteControl.PressUndo();

//// Undo again (should turn light off again)
//remoteControl.PressUndo();

//remoteControl.LogHistory();

//Console.WriteLine("\n=== Toplu Komut Testi (Direkt) ===");
//var remoteControl2 = new RemoteControl();
//var lightReceiver2 = new LightReceiverProcess();

//remoteControl2.ExecuteCommands(
//    new LightOn(lightReceiver2),
//    new LightOff(lightReceiver2),
//    new LightOn(lightReceiver2)
//);

//remoteControl2.LogHistory();

//Console.WriteLine("\nUndo işlemleri:");
//remoteControl2.PressUndo();
//remoteControl2.PressUndo();

//remoteControl2.LogHistory();

//Console.WriteLine("\n=== Queue Mekanizması (Önce Ekle, Sonra Çalıştır) ===");
//var remoteControl3 = new RemoteControl();
//var lightReceiver3 = new LightReceiverProcess();

//// Komutları kuyruğa ekle
//remoteControl3.AddToQueue(new LightOn(lightReceiver3));
//remoteControl3.AddToQueue(new LightOff(lightReceiver3));
//remoteControl3.AddToQueue(new LightOn(lightReceiver3));
//remoteControl3.AddToQueue(new LightOff(lightReceiver3));

//// Kuyruğu görüntüle
//remoteControl3.LogQueue();

//// Tüm kuyruğu çalıştır
//remoteControl3.ExecuteQueue();

//// History'yi kontrol et
//remoteControl3.LogHistory();

//// Undo yap
//Console.WriteLine("\nUndo işlemleri:");
//remoteControl3.PressUndo();
//remoteControl3.PressUndo();

//remoteControl3.LogHistory();

#endregion

#region Example 2

using CommandDP.Example2.Commands;
using CommandDP.Example2.Invokers;
using CommandDP.Example2.Receivers;

BankAccount bankAcc = new() { Id = 1 };
var bankAccManager = new BankAccountManager();

Console.WriteLine(bankAcc.ToString());

bankAccManager.ExecuteCommand(new DepositCommand(bankAcc, 500));

Console.WriteLine(bankAcc.ToString());

bankAccManager.ExecuteCommand(new WithdrawCommand(bankAcc, 200));

Console.WriteLine(bankAcc.ToString());

bankAccManager.UndoLastCommand();

Console.WriteLine(bankAcc.ToString());

bankAccManager.UndoLastCommand();

Console.WriteLine(bankAcc.ToString());

bankAccManager.RedoLastCommand();

Console.WriteLine(bankAcc.ToString());

#endregion