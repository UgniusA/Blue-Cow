using UnityEngine;

public interface IPowerUps {
    void ApplyPowerUp();
}

public class JumpPowerUp : IPowerUps {
    public float velocity = 0.0f;

    public void ApplyPowerUp() {
        throw new System.NotImplementedException();
    }
}

public class SpeedPowerUp : IPowerUps {
    public float velocity = 0.0f;

    public void ApplyPowerUp() {
        throw new System.NotImplementedException();
    }
}