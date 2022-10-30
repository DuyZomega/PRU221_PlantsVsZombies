using System.Collections;
using System.Collections.Generic;

    public interface ZombieState
    {
        void Walking();
        void Attacking();
        void Dying();
    }