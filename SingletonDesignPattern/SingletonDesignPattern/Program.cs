using SingletonDesignPattern;

//Camera camera1 = Camera.GetCamera();
//Camera camera2 = Camera.GetCamera();
//Camera camera3 = Camera.GetCamera();
//Camera camera4 = Camera.GetCamera();
//Camera camera5 = Camera.GetCamera();
//Camera camera6 = Camera.GetCamera();
//Camera camera7 = Camera.GetCamera();
//io,cpu
//CreateThread, CreateremoteThread

Parallel.For(0, 10, (item) =>
{
    Camera camera1 = Camera.GetCamera();

});

