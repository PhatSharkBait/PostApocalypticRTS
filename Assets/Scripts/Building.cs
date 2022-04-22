public class Building : Creation {
    private int _buildingTime;
    private bool _resourceDropoff;

    public override bool CanBeBuilt() {
        return true;
    }
}
