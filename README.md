# D2MPQ (Diablo II: LOD) *Protection* 
This is for byte swapping the .MPQ's and Storm.dll for the Diablo II: LOD 1.13c client.
You can also change these offsets for a newer or older client as well.
 
This will add basic protection from someone just plainly opening and browsing your .MPQ files, while the game is running perfectly fine still.
Just simply drag and drop into the executable itself. You will have to-do **each** .MPQ file one-by-one. Lastly, your Storm.dll.

Again, this is just for a quick edit. Someone with any experince can remove this... At least I'd think so.
But, you can also apply UPX (https://github.com/upx/upx/releases/download/v3.96/upx-3.96-win64.zip) on your Storm.dll for further protection. Just be sure to change your Section Headers from the default UPX with something like CFF Explorer afterwards. So the UPX packed Storm.dll isn't as *easily* removed (unpacking).
