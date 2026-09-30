// 1
//int counter = 0;

//void countIncrement()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Interlocked.Increment(ref counter);
//    }
//}

//Thread thread1 = new Thread(countIncrement);
//Thread thread2 = new Thread(countIncrement);
//Thread thread3 = new Thread(countIncrement);
//Thread thread4 = new Thread(countIncrement);
//Thread thread5 = new Thread(countIncrement);

//thread1.Start();
//thread2.Start();
//thread3.Start();
//thread4.Start();
//thread5.Start();

//thread1.Join();
//thread2.Join();
//thread3.Join();
//thread4.Join();
//thread5.Join();

//Console.WriteLine(counter);


// 2
//int counter = 0;

//Semaphore semaphore = new Semaphore(2, 2);
//ManualResetEvent allDone = new ManualResetEvent(false);

//void ProcessOrders()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        semaphore.WaitOne();
//        try
//        {
//            Interlocked.Increment(ref counter);
//        }
//        finally
//        {
//            semaphore.Release();
//        }
//    }
//}

//void WaitForAll()
//{
//    allDone.WaitOne();
//    Console.WriteLine("All orders have been processed!");
//}

//Thread thread1 = new Thread(ProcessOrders);
//Thread thread2 = new Thread(ProcessOrders);
//Thread thread3 = new Thread(ProcessOrders);
//Thread thread4 = new Thread(ProcessOrders);
//Thread thread5 = new Thread(ProcessOrders);
//Thread waiter = new Thread(WaitForAll);

//waiter.Start();
//thread1.Start();
//thread2.Start();
//thread3.Start();
//thread4.Start();
//thread5.Start();

//thread1.Join();
//thread2.Join();
//thread3.Join();
//thread4.Join();
//thread5.Join();

//Console.WriteLine(counter);
//allDone.Set();
//waiter.Join();