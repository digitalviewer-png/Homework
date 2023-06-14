CargoPlane Plane1 = new CargoPlane("Plane1", 1982, 150000, "Blue", 30, 500);
CargoPlane Plane2 = new CargoPlane("Plane2", 1999, 100000, "Green", 20, 200);

PassengerPlane IL62 = new PassengerPlane("IL62", 1966, 70400, "White", 43.2, 186);
PassengerPlane IL86 = new PassengerPlane("IL86", 1967, 113950, "White-Blue", 48.1, 350);

Car Subaru = new Car("Subaru", 2000, 3, "Black", 250);
Car Toyota = new Car("Toyota", 1980, 3, "White", 280);

Truck Ford = new Truck("Ford", 2000, 4, "Orange", 200, 5);
Truck Ram = new Truck("Ram", 2010, 4, "Gray", 180, 4);

Train Train1 = new Train("Train1", 1950, 200000, "Mixed", 420);
Train Train2 = new Train("Train2", 1920, 300000, "Black", 300);

Plane1.Info();
Plane2.Info();
IL62.Info();
IL86.Info();
Subaru.Info();
Toyota.Info();
Ford.Info();
Ram.Info();
Train1.Info();
Train2.Info();