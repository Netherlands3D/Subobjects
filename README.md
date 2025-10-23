> Archived – Now maintained in the Netherlands3D Main Repository; OpenUPM updates suspended.

# Object Coloring

Package get acces to subobjects in unity Meshes.

## Installing

This package is provided through OpenUPM, to install it using the CLI you can perform the following:

```bash
$ openupm add netherlands3d.Subobjects
```

or, you have to add `https://package.openupm.com` as a scoped registry with, at least, the following scopes:

- `eu.netherlands3d`

## Usage

### Adding ObjectMapping
add an objectMapping-class to a gameObject with a mesh. 
for each part in the mesh that you want to uniquely identify add an ObjectMappingItem to the items-list, containing the unique Identifier, the first index of the first vertex associated with the item and the number of vertices associated with the item.

### Override the color
- Create color maps as Dictionaries<string, Color>. add a prioritization index and add them to the GeometryColorizer.
the vertexcolors of the meshes will be adjusted appropriately.

# Repository Archived

This repository has been **archived** and is no longer maintained independently.

The contents of this package have been merged into the  
**[Netherlands3D Main Repository](https://github.com/Netherlands3D/twin)**  
into the `Packages` folder.

## Current Location

The latest version and future updates of this package will be maintained inside the Netherlands3D main repository as part of an effort to simplify and unify our development workflow.

## Why was this repository archived?

To streamline development and reduce overhead, the Netherlands3D packages are being integrated into the main repository.  
This approach allows for better coordination between packages and features, while we continue to evaluate whether a full monorepo setup (including versioning) is desirable in the future.

## Where to contribute

Please open issues and pull requests in the [Netherlands3D Main Repository](https://github.com/Netherlands3D/twin).

## Publication status

Updates to this package on **OpenUPM** are **suspended until further notice**.  
Future releases will be managed from the main repository once the new development flow has been finalized.

## Historical reference

This repository remains available in read-only mode as a historical record of its standalone development.

