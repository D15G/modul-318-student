namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station);
        Connections GetConnections(string fromStation, string toStattion, string time, string date);
    }
}