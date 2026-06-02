public boolean connect(String location)
{
    try
    {
        Connection con =
            DriverManager.getConnection(location);

        return true;
    }
    catch(Exception e)
    {
        return false;
    }
}