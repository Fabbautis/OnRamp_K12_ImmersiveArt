Unity Style Guide
=================

# Intro

***This document is a work in progress and will most likely change over the life of the project.***  

This document will be the authoritative guide on how the project should be structured, how assets should be named, where they should be placed, etc.  

This style guide is a conglomeration of multiple different guides and styles. Many things are copied from the [stillwwater Ramen Unity Style Guide](https://github.com/stillwwater/UnityStyleGuide).  

# Project Structure

## Assets
```
Art
├── Animations
│   ├── Clips
│   └── Controllers
├── Shaders
├── Textures          # Includes Sprites and Spritesheets
└── UI
Audio
├── Sounds
└── Music
Editor
Level                 # Anything pertaining to game or level design
├── Prefabs
└── Scenes
```

# Naming Conventions

## Folders

`PascalCase`

Prefer a deep folder structure over having long asset names.

Directory names should be as concise as possible, prefer one or two words. If a directory name is too long, it probably makes sense to split it into sub directories.

Try to have only one file type per folder. Use `Textures/Trees`, `Models/Trees` and not `Trees/Textures`, `Trees/Models`. That way its easy to set up root directories for the different software involved, for example, Substance Painter would always be set to save to the Textures directory.

If your project contains multiple environments or art sets, use the asset type for the parent directory: `Trees/Jungle`, `Trees/City` not `Jungle/Trees`, `City/Trees`. Since it makes it easier to compare similar assets from different art sets to ensure continuity across art sets.

