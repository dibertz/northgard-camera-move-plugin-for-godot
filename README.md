# northgard-camera-move

A plugin RTS camera move system made in Godot Engine 3.4 imitating to the Northgard game.
<br>
```diff
+ Recent version V.0.9.5 with new features and fixes applied.
- JRPG Plugin 
```

<h2>Intrduction:</h2>

JRPG-camera-move-v.0.9 it's a tool designed for to RTS Games and RPGs. Let you make a real time strategy 3D game.

<h2>What it does:</h2>
<p>
 Move Camera with Mouse in Godot 3D, fading in and in-out smoothing, customizable parameters, keyboard camera control, player tracking camera, zoom in-out. Displacement across map x, y, z and diagonal with Map Range Clamped system. Set up the "Kinematic Character Move" interactive.
</p>
<p>
 <a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/FH3t3XPv/Mouse-Camera-gif-maker.gif' border='0' alt='Mouse-Camera-gif-maker'/></a>
</p>
<br>
<p>
 The Y key is used to lock or free-view camera.
 
 --------------------------------------
 
 <b>Free-View Cam: First gif image
  
  <a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/4NBdXHqH/demo-ahri-rts.gif' border='0' alt='demo-ahri-rts'/></a>
  
  Lock-View Cam: Second gif image</b>
 
  --------------------------------------
 
</p>
<br>
<p>
 Keys A, W, D, S is used to move character and tracking with camera smoothing.
</p>
<p>
 <a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/kMzXvfgJ/smoothing-Camera-gif-maker.gif' border='0' alt='smoothing-Camera-gif-maker'/></a>
</p>
<br>
<p>
 The mouse wheel scrolling + or - is used to Zoom in-out Camera. Even you can scrollable and zoom.
</p>
<p>
 <a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/d33Rcv7T/zoom-Camera-gif-maker.gif' border='0' alt='zoom-Camera-gif-maker'/></a>
</p>
<br>
<h2>Operative systems compatibility:</h2>

MacOS

Linux

Windows

<h2>Requeriments:</h2>

Godot_v3.4.2-stable_mono_win64 (Mono Version).

Don't matter if you code in GDScript, it enabled for both C# or GDScript.

GLES3 (GPU Driver Compatibility OpenGL 3.3).

<h2>Get Started:</h2>

Copy or clone repository inside of ➤ C:\Users\YourName\Documents\YourGodotProject\addons

<h3>Start Project:</h2>

1. Run Godot Engine 3.4 (C# Version required to run the plugin).
2. Create a new node type Spatial and rename for 'SampleScene'.
3. Attach a new script type C# (give it another name is not SampleScene).You will be able to remove it later and write GDScript code.
4. Now clicked in Build or Alt + B.
5. To enable the freshly installed plugin, open Project > Project Settings at the top of the editor then go the Plugins tab.
6. Active to enable the plugin > rts_camera_move
7. Press the "Add Child Node" button at the top left of the Scene dock to create a node. This button adds the chosen node as a child of the currently selected one or, in an empty scene, as the root.
8. Select the node Spatial > RTSCameraMove3D. You can type it's name to filter down the list.
9. Click the RTSCameraMove3D node and check the "Editor Description" to know how to set up the Input Maps.
10. <a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/gJv4CdSs/node-select.png' border='0' alt='node-select'/></a>
11. Set up the Input Map to enable Mouse Zoom and Character Move (PASS 9). Project > Project Settings > Input Map.
12. Finally the setup has been completed, save the project and press Build.
13. Run the Game.

<h2>Contributing</h2>
Contributions to the development and enahancement of JRPG/RTS data is welcome. Please see <a href="https://github.com/dibertz/northgard-camera-move-plugin-for-godot/blob/main/CONTRIBUTING.md">CONTRIBUTING.md</a> for contribution guidelines.

<h2>FAQ:</h2>

If you have any questions or doubts comment in the description into below.

1. <b>How to set up the parameters and settings?</b>
<br>Into Godot editor double-click FileSystem > addons > rts_camera_move > "SampleScene.tscn". Now in the new window can going to SampleScene > TrackingCamera > Camera and here variables it can be changed.
2. <b>What is size map clamped it?</b>
<br>Higher values than the default value means a symmetric larger map. It should keep the same dimensions on both sides to avoid clamping critical errors.
3. <b>How to does put my 3D character model without watch for the ugly cube?</b>
<br>It's super easy, click on node Mesh Instance (SampleScene/Player/Pivot/MeshInstance) and REMOVE, so replace it for your own. 
<br>Set up to Scale X 0.1, Y 0.1, Z 0.1 and Traslation X 0.0, Y 0.1, Z 0.0. That's it.

Do you want more features?, check it out repositories weekly.

<h2>Licensed Under MIT</h2>

<a href='https://www.paypal.com/donate/?hosted_button_id=EWDLXT7WUVYZ2' target='_blank'><img src='https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif' border='0' alt='Donate with PayPal button'/></a>


Enjoy it!

