using ETCS.Factories;
using ETCS.Model;
using ETCS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.DependencyInjection
{
    public class DependencyClass
    {
        IRepoFactory repoFactory;
        public DependencyClass(IRepoFactory repoFactory)
        {
            this.repoFactory = repoFactory;
        }

        public void startUp()
        {
            IRepo<VehicleType> vehicleTypeRepo = repoFactory.CreateRepo<VehicleType>();
            vehicleTypeRepo.AddRange(new VehicleType[]
            {
                new VehicleType {id = 1, typeName = "Car", tollFee = 250 },
                new VehicleType {id = 2, typeName = "Truck", tollFee = 500 },
                new VehicleType {id = 3, typeName = "Motorcycle", tollFee = 100 },
                new VehicleType {id = 4, typeName = "Bus", tollFee = 400 }
            });

            Console.WriteLine("======================= Get All Vehicle Types =======================");
            vehicleTypeRepo.GetAll().ForEach(vt => Console.WriteLine($"Type: {vt.typeName}, Toll Fee: {vt.tollFee}"));

            Console.WriteLine();
            Console.WriteLine("======================= Get by ID Vehicle Types =======================");
            var vehicleType = vehicleTypeRepo.GetById(2);
            Console.WriteLine($"Type: {vehicleType.typeName}, Toll Fee: {vehicleType.tollFee}");

            Console.WriteLine();
            Console.WriteLine("======================= Update Vehicle Types =======================");
            vehicleType.tollFee = 60.00;
            vehicleTypeRepo.Update(vehicleType);
            var updatedVehicleType = vehicleTypeRepo.GetById(3);
            Console.WriteLine($"Type: {updatedVehicleType.typeName}, Toll Fee: {updatedVehicleType.tollFee}");

            Console.WriteLine();
            Console.WriteLine("======================= Delete Vehicle Types =======================");
            vehicleTypeRepo.Delete(4);
            vehicleTypeRepo.GetAll().ForEach(vt => Console.WriteLine($"Type: {vt.typeName}, Toll Fee: {vt.tollFee}"));

            Console.WriteLine();
            Console.WriteLine("======================= Add Driver Transaction =======================");
            IRepo<DriverTransaction> driverTransactionRepo = repoFactory.CreateRepo<DriverTransaction>();
            driverTransactionRepo.AddRange(new DriverTransaction[]
            {
                new DriverTransaction { id = 1, name = "Nakibul Islam Fahim", licenseNumber = "DHA-423", vehicleTypeId = 1, transactionDate = DateTime.Now },
                new DriverTransaction { id = 2, name = "Azman Ali", licenseNumber = "DHA-321", vehicleTypeId = 1, transactionDate = DateTime.Now },
                new DriverTransaction { id = 3, name = "Ahsanul Nafeez", licenseNumber = "KHL-456", vehicleTypeId = 3, transactionDate = DateTime.Now },
                new DriverTransaction { id = 4, name = "Sheikh Ehsanul", licenseNumber = "THK-789", vehicleTypeId = 2, transactionDate = DateTime.Now },
                new DriverTransaction { id = 5, name = "Omar Faruq", licenseNumber = "DHA-654", vehicleTypeId = 2, transactionDate = DateTime.Now }
            });
            Console.WriteLine();
            Console.WriteLine("======================= Get All Driver Transactions =======================");
            driverTransactionRepo.GetAll().ForEach(dt => Console.WriteLine($"Name: {dt.name}, License Number: {dt.licenseNumber}, Vehicle Type ID: {dt.vehicleTypeId}, Transaction Date: {dt.transactionDate}"));
        }
    }
}
