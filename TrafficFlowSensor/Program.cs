/*
 * Bill Nicholson
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
            trafficFLowSensorThread.Join();
            Console.WriteLine("Vehicle count = " + carCount);
        }
        private static void ProcessSensorOutput(int numOfCars)
        {
            Console.WriteLine("Vehicle count: " + numOfCars);
            carCount += numOfCars;
        }
    }
}
