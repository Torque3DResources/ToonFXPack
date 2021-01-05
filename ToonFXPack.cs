function ToonFXPack::onCreate(%this)
{
}

function ToonFXPack::onDestroy(%this)
{
}

//This is called when the server is initially set up by the game application
function ToonFXPack::initServer(%this)
{
}

//This is called when the server is created for an actual game/map to be played
function ToonFXPack::onCreateGameServer(%this)
{
   %this.registerDatablock("./datablocks/ToonEffects.cs");
   %this.registerDatablock("./datablocks/ToonExp_StandardExplosionSmall.cs");
   %this.registerDatablock("./datablocks/ToonExp_StandardExplosionBig.cs");
   %this.registerDatablock("./datablocks/ToonExp_PuffSmall.cs");
   %this.registerDatablock("./datablocks/ToonExp_PuffBig.cs");
   %this.registerDatablock("./datablocks/ToonExp_BurstSmall.cs");
   %this.registerDatablock("./datablocks/ToonExp_BurstBig.cs");
   %this.registerDatablock("./datablocks/ToonExp_SplashSmall.cs");
   %this.registerDatablock("./datablocks/ToonExp_SplashBig.cs");
}

//This is called when the server is shut down due to the game/map being exited
function ToonFXPack::onDestroyGameServer(%this)
{
}

//This is called when the client is initially set up by the game application
function ToonFXPack::initClient(%this)
{
}

//This is called when a client connects to a server
function ToonFXPack::onCreateClientConnection(%this)
{
}

//This is called when a client disconnects from a server
function ToonFXPack::onDestroyClientConnection(%this)
{
}
