class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int battery = 100;
    public int metersDriven = 0;
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => this.battery < this.batteryDrain;

    public int DistanceDriven() => this.metersDriven;

    public void Drive() 
    {
        if (!BatteryDrained()){
            this.metersDriven += this.speed;
            this.battery -= this.batteryDrain;
        }
        
    } 

    public static RemoteControlCar Nitro() => new RemoteControlCar(50,4);
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car){
        while(!car.BatteryDrained()){
            car.Drive();
        }return car.metersDriven >= this.distance;
    }
}
