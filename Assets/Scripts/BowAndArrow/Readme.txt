Bow and Arrow Asset
(c) 2016 Digital Ruby, LLC
http://www.digitalruby.com

I'm Jeff Johnson and I created bow and arrow for an archery game. Having spent so many hours on the bow and arrow I figured I should share it with the world. I hope you enjoy this asset.

The default bow should work well, but there may be a few setup steps depending on your orthographic size.

Here's what to check
- You may need to change the bow shaft and arrow texture pixels per unit to something appropriate for your game.
- Set the max rotation on the bow depending on whether you want the bow to rotate at all.
- Set the cooldown, fizzle speed and fire speed to appropriate values for your game.
- Adjust the box collider of DrawStartArea and DrawTotalArea depending on how far back you want to allow the bow to be drawn back. The defaults should work pretty well.
- Enable / disable fizzling depending on whether you want the bow to be able to mis-fire.

To fire the bow, click and drag the bow string backwards. Release to fire the arrow. If you draw the bow too far forward, back or off center, the arrow will fizzle out if you have set EnableFizzling on (the default).

If you need to use the bow and arrow script in another script, make sure to include "using DigitalRuby.BowAndArrow;"

As always, please email support@digitalruby.com and I will try to help.