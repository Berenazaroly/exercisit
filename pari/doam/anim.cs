public static void PlaceFinderPatterns(ref QRCodeData qrCode, ref List<Rectangle> blockedModules) {
    var size = qrCode.ModuleMatrix.Count;
    int[] locations = { 0, 0, size - 7, 0, 0, size - 7 };
    for (var i = 0; i < 6; i = i + 2) {
        for (var x = 0; x < 7; x++) {
            for (var y = 0; y < 7; y++) {
                if (!(((x == 1 || x == 5) && y > 0 && y < 6) || (x > 0 && x < 6 && (y == 1 || y == 5)))) {
                    qrCode.ModuleMatrix[y + locations[i + 1]][x + locations[i]] = true;
                }
            }
        }
        blockedModules.Add(new Rectangle(locations[i], locations[i + 1], 7, 7));
    }
}
