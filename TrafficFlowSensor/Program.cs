/*
 * Bill Nicholson
 * 
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Threading;
using TrafficFlowSensorNamespace;

namespace TrafficFlowSensorDemoNamespace
{
    public class TrafficFlowSensorDemo
    {
        private static int carCount;
        /// <summary>
        /// Demo for the ThreadDemo class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            carCount = 0;
            TrafficFlowSensor trafficFLowSensor = new TrafficFlowSensor();
            Thread trafficFLowSensorThread = trafficFLowSensor.StartSensor("College Drive", ProcessSensorOutput, 0);

            // Do whatever you want here. 
            // ...
            for (int i = 0; i < 10; i++) { Console.Write("Working "); Thread.Sleep(1000); }

            // If you get to the end of the main and you don't want the app to end yet, join the Traffic Flow Sensor thread.
            trafficFLowSensorThread.Join();
            Console.WriteLine("Vehicle count = " + carCount);
        }
        /// <summary>
        /// This method will be called by the sensor when traffic is registered. 
        /// It happens in real time. The main can go about whatever business it wants to do.
        /// </summary>
        /// <param name="numOfCars"></param>
        private static void ProcessSensorOutput(int numOfCars)
        {
            Console.WriteLine("Vehicle count: " + numOfCars);
            carCount += numOfCars;
        }
    }
}
