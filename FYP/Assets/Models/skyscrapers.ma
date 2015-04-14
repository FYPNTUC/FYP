//Maya ASCII 2014 scene
//Name: skyscrapers.ma
//Last modified: Wed, Nov 12, 2014 11:23:27 AM
//Codeset: 1252
requires maya "2014";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2014";
fileInfo "version" "2014";
fileInfo "cutIdentifier" "201401300447-905052";
fileInfo "osv" "Microsoft Windows 7 Enterprise Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "education";
createNode transform -s -n "persp";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -293.61967816775189 153.9984982348864 -142.12850277350239 ;
	setAttr ".r" -type "double3" -18.338352729452204 2056.1999999997788 0 ;
createNode camera -s -n "perspShape" -p "persp";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999986;
	setAttr ".coi" 340.05065682488538;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" 0 295.25460097362429 -28.849469838892755 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0.49666558641149727 294.77487843037153 5.5058789776593747e-005 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 109.23364433693193;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 100.1 ;
createNode camera -s -n "frontShape" -p "front";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 100.1 0 0 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "group";
	setAttr ".rp" -type "double3" -202.34448042048007 -66.338139867038564 72.223527842518493 ;
	setAttr ".sp" -type "double3" -202.34448042048007 -66.338139867038564 72.223527842518493 ;
createNode transform -n "skyscraper1" -p "group";
	setAttr ".rp" -type "double3" 0 153.44947602708757 0 ;
	setAttr ".sp" -type "double3" 0 153.44947602708757 0 ;
createNode mesh -n "skyscraperShape1" -p "skyscraper1";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.36719116568565369 0.71210449934005737 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.75582111 0.016724393
		 0.97716212 0.016724393 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.021374285 0.013311341 0.23469037 0.013311341 0.50339544 0.016724393
		 0.72441298 0.016724393 0.23469037 0.70874316 0.021374285 0.70874316 0.48001319 0.7121045
		 0.25436914 0.7121045 0.25436914 0.016672686 0.48001319 0.016672686 0.72441298 0.70953292
		 0.50339544 0.70953292 0.97716212 0.71209818 0.75582111 0.71209818;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -22.91991 41.905041 28.265081 
		22.91991 41.905041 28.265081 -22.91991 264.9938 28.265081 22.91991 264.9938 28.265081 
		-22.91991 264.9938 -28.264999 22.91991 264.9938 -28.264999 -22.91991 41.905041 -28.264999 
		22.91991 41.905041 -28.264999;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group1";
	setAttr ".rp" -type "double3" -202.34448042048007 -54.93354605833035 34.638668495367071 ;
	setAttr ".sp" -type "double3" -202.34448042048007 -54.93354605833035 34.638668495367071 ;
createNode transform -n "skyscraper2" -p "group1";
	setAttr ".rp" -type "double3" 0.49666615730222574 171.24157243713347 0 ;
	setAttr ".sp" -type "double3" 0.49666615730222574 171.24157243713344 0 ;
createNode mesh -n "skyscraperShape2" -p "skyscraper2";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.61069017648696899 0.70926139330210747 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.76017255 0.016724393
		 0.97716212 0.016724393 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.025696527 0.016672686 0.2330097 0.016672686 0.50339544 0.016724393
		 0.71798491 0.016724393 0.2330097 0.7100758 0.025696527 0.7100758 0.48001319 0.7100758
		 0.26030439 0.7100758 0.26030439 0.016672686 0.48001319 0.016672686 0.71798491 0.70926142
		 0.50339544 0.70926142 0.97716212 0.71103072 0.76017255 0.71103072;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -22.013668 42.765976 27.545792 
		23.006998 42.765976 27.545792 -22.013668 299.71701 27.545792 23.006998 299.71701 
		27.545792 -22.013668 299.71701 -27.54571 23.006998 299.71701 -27.54571 -22.013668 
		42.765976 -27.54571 23.006998 42.765976 -27.54571;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group2";
	setAttr ".rp" -type "double3" -202.34448042048007 -70.892451520034996 -1.714947583021277 ;
	setAttr ".sp" -type "double3" -202.34448042048007 -70.892451520034996 -1.714947583021277 ;
createNode transform -n "skyscraper3" -p "group2";
	setAttr ".rp" -type "double3" 0 147.51765687474224 1.5258789062499966e-005 ;
	setAttr ".sp" -type "double3" 0 147.51765687474224 1.5258789062499966e-005 ;
createNode mesh -n "skyscraperShape3" -p "skyscraper3";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.86649161577224731 0.71295326948165894 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.75582111 0.012153952
		 0.97716212 0.012153952 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.019693613 0.012102245 0.2330097 0.012102245 0.50339544 0.012153952
		 0.72441298 0.012153952 0.2330097 0.71157849 0.019693613 0.71157849 0.48001319 0.71185702
		 0.25436914 0.71185702 0.25436914 0.012102245 0.48001319 0.012102245 0.72441298 0.7118507
		 0.50339544 0.7118507 0.97716212 0.71295327 0.75582111 0.71295327;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -25.035112 41.971874 16.13867 
		25.035112 41.971874 16.13867 -25.035112 253.06351 16.13867 25.035112 253.06351 16.13867 
		-25.035112 253.06351 -16.138678 25.035112 253.06351 -16.138678 -25.035112 41.971874 
		-16.138678 25.035112 41.971874 -16.138678;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group3";
	setAttr ".rp" -type "double3" -202.34448042048007 -54.826998775466322 117.73234516978694 ;
	setAttr ".sp" -type "double3" -202.34448042048007 -54.826998775466322 117.73234516978694 ;
createNode transform -n "skyscraper4" -p "group3";
	setAttr ".rp" -type "double3" 0 134.18743576659952 0 ;
	setAttr ".sp" -type "double3" 0 134.18743576659952 0 ;
createNode mesh -n "skyscraperShape4" -p "skyscraper4";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.4984278678894043 0.016698536144135856 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.75582111 0.016724393
		 0.97716212 0.016724393 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.019693613 0.016672686 0.2330097 0.016672686 0.50339544 0.016724393
		 0.72441298 0.016724393 0.2330097 0.71295959 0.019693613 0.71295959 0.48001319 0.71295959
		 0.25436914 0.71295959 0.25436914 0.016672686 0.48001319 0.016672686 0.72441298 0.71295327
		 0.50339544 0.71295327 0.97716212 0.71295327 0.75582111 0.71295327;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -23.414743 41.834763 27.315731 
		23.414743 41.834763 27.315731 -23.414743 226.54004 27.315731 23.414743 226.54004 
		27.315731 -23.414743 226.54004 -27.315647 23.414743 226.54004 -27.315647 -23.414743 
		41.834763 -27.315647 23.414743 41.834763 -27.315647;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group4";
	setAttr ".rp" -type "double3" -209.59766035447112 -62.408191748053753 -43.237649178322492 ;
	setAttr ".sp" -type "double3" -209.59766035447112 -62.408191748053753 -43.237649178322492 ;
createNode transform -n "skyscraper5" -p "group4";
	setAttr ".rp" -type "double3" 0 126.5196862498634 0 ;
	setAttr ".sp" -type "double3" 0 126.5196862498634 0 ;
createNode mesh -n "skyscraperShape5" -p "skyscraper5";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.7558211088180542 0.36483883112668991 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.75582111 0.016724393
		 0.97716212 0.016724393 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.019693613 0.016672686 0.2330097 0.016672686 0.51221794 0.016724393
		 0.72441298 0.016724393 0.2330097 0.71295959 0.019693613 0.71295959 0.47560194 0.71295959
		 0.25436914 0.71295959 0.25436914 0.016672686 0.47560194 0.016672686 0.72441298 0.71295327
		 0.51221794 0.71295327 0.97716212 0.71295327 0.75582111 0.71295327;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -25.98633 41.517406 21.586895 
		25.98633 41.517406 21.586895 -25.98633 211.52185 21.586895 25.98633 211.52185 21.586895 
		-25.98633 211.52185 -21.58683 25.98633 211.52185 -21.58683 -25.98633 41.517406 -21.58683 
		25.98633 41.517406 -21.58683;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group5";
	setAttr ".rp" -type "double3" -209.59766035447112 -47.803111069566945 -81.627771572576648 ;
	setAttr ".sp" -type "double3" -209.59766035447112 -47.803111069566945 -81.627771572576648 ;
createNode transform -n "skyscraper6" -p "group5";
	setAttr ".rp" -type "double3" 0 146.2168722915047 0 ;
	setAttr ".sp" -type "double3" 0 146.2168722915047 0 ;
createNode mesh -n "skyscraperShape6" -p "skyscraper6";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.75942430245776116 0.36376392096281052 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0.75942427 0.016724393
		 0.97716212 0.016724393 0.18418765 0.73151803 0.43771148 0.73151803 0.43771148 0.98504162
		 0.18418765 0.98504162 0.51545906 0.73026842 0.76898265 0.73026842 0.76898265 0.98379207
		 0.51545906 0.98379207 0.019693613 0.016672686 0.23110841 0.016672686 0.50339544 0.016724393
		 0.72441298 0.016724393 0.23110841 0.71080238 0.019693613 0.71080238 0.47782138 0.71080238
		 0.25627044 0.71080238 0.25627044 0.016672686 0.47782138 0.016672686 0.72441298 0.71080345
		 0.50339544 0.71080345 0.97716212 0.71080345 0.75942427 0.71080345;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".pt[0:7]" -type "float3"  -23.423124 42.819061 20.433846 
		23.423124 42.819061 20.433846 -23.423124 249.61456 20.433846 23.423124 249.61456 
		20.433846 -23.423124 249.61456 -20.433784 23.423124 249.61456 -20.433784 -23.423124 
		42.819061 -20.433784 23.423124 42.819061 -20.433784;
	setAttr -s 8 ".vt[0:7]"  -15.72631836 -42.19116211 12.71083069 15.72631836 -42.19116211 12.71083069
		 -15.72631836 42.1911087 12.71083069 15.72631836 42.1911087 12.71083069 -15.72631836 42.1911087 -12.71079254
		 15.72631836 42.1911087 -12.71079254 -15.72631836 -42.19116211 -12.71079254 15.72631836 -42.19116211 -12.71079254;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 22 23
		f 4 1 7 -3 -7
		mu 0 4 2 3 4 5
		f 4 2 9 -4 -9
		mu 0 4 16 17 18 19
		f 4 3 11 -1 -11
		mu 0 4 6 7 8 9
		f 4 -12 -10 -8 -6
		mu 0 4 10 11 14 15
		f 4 10 4 6 8
		mu 0 4 12 13 20 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode transform -n "group6";
	setAttr ".rp" -type "double3" 1.9073486328125e-006 2.0861625671386719e-007 3.814697265625e-006 ;
	setAttr ".sp" -type "double3" 1.9073486328125e-006 2.0861625671386719e-007 3.814697265625e-006 ;
createNode transform -n "pasted__group" -p "group6";
	setAttr ".rp" -type "double3" 27.833855233566567 0.76708126733760373 -145.04354257175524 ;
	setAttr ".sp" -type "double3" 27.833855233566567 0.76708126733760373 -145.04354257175524 ;
createNode transform -n "group7";
	setAttr ".rp" -type "double3" -66.889599032238181 28.41847236037059 23.30713756807716 ;
	setAttr ".sp" -type "double3" -66.889599032238181 28.41847236037059 23.30713756807716 ;
createNode transform -n "left";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -342.00812246445707 0 0 ;
	setAttr ".r" -type "double3" 0 -89.999999999999986 0 ;
createNode camera -n "leftShape" -p "left";
	setAttr -k off ".v";
	setAttr ".rnd" no;
	setAttr ".coi" 342.00812246445707;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "left1";
	setAttr ".den" -type "string" "left1_depth";
	setAttr ".man" -type "string" "left1_mask";
	setAttr ".hc" -type "string" "viewSet -ls %camera";
	setAttr ".o" yes;
createNode lightLinker -s -n "lightLinker1";
	setAttr -s 10 ".lnk";
	setAttr -s 10 ".slnk";
createNode displayLayerManager -n "layerManager";
	setAttr ".cdl" 2;
	setAttr -s 8 ".dli[1:7]"  1 2 3 4 5 6 7;
	setAttr -s 7 ".dli";
createNode displayLayer -n "defaultLayer";
createNode renderLayerManager -n "renderLayerManager";
createNode renderLayer -n "defaultRenderLayer";
	setAttr ".g" yes;
createNode materialInfo -n "pasted__materialInfo40";
createNode shadingEngine -n "pasted__lambert41SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper1texture";
createNode file -n "pasted__skyscraper1textur";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper1.tga";
createNode place2dTexture -n "pasted__place2dTexture41";
createNode script -n "uiConfigurationScriptNode";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"persp\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n"
		+ "                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 1\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 1\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 8192\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -maxConstantTransparency 1\n                -rendererName \"base_OpenGL_Renderer\" \n"
		+ "                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n"
		+ "                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 1\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 1\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 8192\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -maxConstantTransparency 1\n            -rendererName \"base_OpenGL_Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n"
		+ "            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels `;\n"
		+ "\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"side\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"wireframe\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 1\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 8192\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n"
		+ "                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -maxConstantTransparency 1\n                -rendererName \"base_OpenGL_Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n"
		+ "                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n"
		+ "                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"wireframe\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 1\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 8192\n            -fogging 0\n            -fogSource \"fragment\" \n"
		+ "            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -maxConstantTransparency 1\n            -rendererName \"base_OpenGL_Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n"
		+ "            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n"
		+ "\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"front\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"wireframe\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 1\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n"
		+ "                -textureMaxSize 8192\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -maxConstantTransparency 1\n                -rendererName \"base_OpenGL_Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n"
		+ "                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n"
		+ "                -shadows 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"wireframe\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 1\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n"
		+ "            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 8192\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -maxConstantTransparency 1\n            -rendererName \"base_OpenGL_Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n"
		+ "            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n"
		+ "        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"persp\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 1\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 1\n"
		+ "                -displayTextures 1\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 8192\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -maxConstantTransparency 1\n                -rendererName \"base_OpenGL_Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n"
		+ "                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n"
		+ "                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n"
		+ "            -twoSidedLighting 1\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 1\n            -displayTextures 1\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 8192\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -maxConstantTransparency 1\n            -rendererName \"base_OpenGL_Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n"
		+ "            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n"
		+ "            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `outlinerPanel -unParent -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            outlinerEditor -e \n                -showShapes 0\n                -showReferenceNodes 1\n                -showReferenceMembers 1\n                -showAttributes 0\n                -showConnected 0\n                -showAnimCurvesOnly 0\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n"
		+ "                -autoExpand 0\n                -showDagOnly 1\n                -showAssets 1\n                -showContainedOnly 1\n                -showPublishedAsConnected 0\n                -showContainerContents 1\n                -ignoreDagHierarchy 0\n                -expandConnections 0\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 0\n                -highlightActive 1\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"defaultSetFilter\" \n                -showSetMembers 1\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n"
		+ "                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n"
		+ "            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n"
		+ "            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"graphEditor\" -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n"
		+ "                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n"
		+ "                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n"
		+ "                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n"
		+ "                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n"
		+ "                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n"
		+ "                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dopeSheetPanel\" -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n"
		+ "                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n"
		+ "                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n"
		+ "                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n"
		+ "                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"clipEditorPanel\" -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n"
		+ "                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"sequenceEditorPanel\" -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels `;\n"
		+ "\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperGraphPanel\" -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n"
		+ "                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n"
		+ "                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperShadePanel\" -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels `;\n"
		+ "\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"visorPanel\" -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n"
		+ "            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -ignoreAssets 1\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -keyReleaseCommand \"nodeEdKeyReleaseCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -island 0\n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -syncedSelection 1\n                -extendToShapes 1\n                $editorName;;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -ignoreAssets 1\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -keyReleaseCommand \"nodeEdKeyReleaseCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -island 0\n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -syncedSelection 1\n                -extendToShapes 1\n                $editorName;;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"createNodePanel\" -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Texture Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"polyTexturePlacementPanel\" -l (localizedPanelLabel(\"UV Texture Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Texture Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\tif ($useSceneConfig) {\n\t\tscriptedPanel -e -to $panelName;\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"renderWindowPanel\" -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"blendShapePanel\" (localizedPanelLabel(\"Blend Shape\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\tblendShapePanel -unParent -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels ;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tblendShapePanel -edit -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynRelEdPanel\" -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"relationshipPanel\" -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"referenceEditorPanel\" -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"componentEditorPanel\" -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynPaintScriptedPanelType\" -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"scriptEditorPanel\" -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-defaultImage \"\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Top View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Top View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -camera \\\"persp\\\" \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 1\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 1\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 8192\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -maxConstantTransparency 1\\n    -rendererName \\\"base_OpenGL_Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Top View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -camera \\\"persp\\\" \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 1\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 1\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 8192\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -maxConstantTransparency 1\\n    -rendererName \\\"base_OpenGL_Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        setFocus `paneLayout -q -p1 $gMainPane`;\n        sceneUIReplacement -deleteRemaining;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 24 -ast 1 -aet 48 ";
	setAttr ".st" 6;
createNode displayLayer -n "skyscraper01";
	setAttr ".do" 1;
createNode materialInfo -n "pasted__materialInfo41";
createNode shadingEngine -n "pasted__lambert42SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper2texture";
createNode file -n "pasted__skyscraper2text";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper2.tga";
createNode place2dTexture -n "pasted__place2dTexture42";
createNode displayLayer -n "skyscraper02";
	setAttr ".v" no;
	setAttr ".do" 2;
createNode materialInfo -n "pasted__materialInfo42";
createNode shadingEngine -n "pasted__lambert43SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper3texture";
createNode file -n "pasted__skyscraper3textur";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper3.tga";
createNode place2dTexture -n "pasted__place2dTexture43";
createNode displayLayer -n "skyscraper03";
	setAttr ".v" no;
	setAttr ".do" 3;
createNode materialInfo -n "pasted__materialInfo43";
createNode shadingEngine -n "pasted__lambert44SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper4texture";
createNode file -n "pasted__skyscraper4textur";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper4.tga";
createNode place2dTexture -n "pasted__place2dTexture44";
createNode displayLayer -n "skyscraper04";
	setAttr ".v" no;
	setAttr ".do" 4;
createNode materialInfo -n "pasted__materialInfo44";
createNode shadingEngine -n "pasted__lambert45SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper5texture";
createNode file -n "pasted__skyscraper5textur";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper5.tga";
createNode place2dTexture -n "pasted__place2dTexture45";
createNode displayLayer -n "skyscraper05";
	setAttr ".v" no;
	setAttr ".do" 5;
createNode materialInfo -n "pasted__materialInfo45";
createNode shadingEngine -n "pasted__lambert46SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "skyscraper6texture";
createNode file -n "pasted__file45";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/skyscraper/skyscraper6.tga";
createNode place2dTexture -n "pasted__place2dTexture46";
createNode displayLayer -n "skyscraper06";
	setAttr ".v" no;
	setAttr ".do" 6;
createNode materialInfo -n "pasted__pasted__materialInfo46";
createNode shadingEngine -n "pasted__pasted__lambert47SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "pasted__debugareatexture";
createNode file -n "pasted__pasted__file46";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/debugarea.tga";
createNode place2dTexture -n "pasted__pasted__place2dTexture47";
createNode materialInfo -n "pasted__materialInfo3";
createNode shadingEngine -n "pasted__lambert4SG";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "pasted__workertexture";
createNode file -n "pasted__file2";
	setAttr ".ftn" -type "string" "C:/Users/122491h/Desktop/workertexture.tga";
createNode place2dTexture -n "pasted__place2dTexture3";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 10 ".st";
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultShaderList1;
	setAttr -s 10 ".s";
select -ne :defaultTextureList1;
	setAttr -s 8 ".tx";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 8 ".u";
select -ne :defaultRenderingList1;
select -ne :renderGlobalsList1;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 18 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surfaces" "Particles" "Fluids" "Image Planes" "UI:" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 18 0 1 1 1 1 1
		 1 0 0 0 0 0 0 0 0 0 0 0 ;
select -ne :defaultHardwareRenderGlobals;
	setAttr ".fn" -type "string" "im";
	setAttr ".res" -type "string" "ntsc_4d 646 485 1.333";
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "skyscraper01.di" "skyscraper1.do";
connectAttr "skyscraper02.di" "skyscraper2.do";
connectAttr "skyscraper03.di" "skyscraper3.do";
connectAttr "skyscraper04.di" "skyscraper4.do";
connectAttr "skyscraper05.di" "skyscraper5.do";
connectAttr "skyscraper06.di" "skyscraper6.do";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert41SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert42SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert43SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert44SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert45SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert46SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__pasted__lambert47SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "pasted__lambert4SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert41SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert42SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert43SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert44SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert45SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert46SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__pasted__lambert47SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "pasted__lambert4SG.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "pasted__lambert41SG.msg" "pasted__materialInfo40.sg";
connectAttr "skyscraper1texture.msg" "pasted__materialInfo40.m";
connectAttr "pasted__skyscraper1textur.msg" "pasted__materialInfo40.t" -na;
connectAttr "skyscraper1texture.oc" "pasted__lambert41SG.ss";
connectAttr "skyscraperShape1.iog" "pasted__lambert41SG.dsm" -na;
connectAttr "pasted__skyscraper1textur.oc" "skyscraper1texture.c";
connectAttr "pasted__place2dTexture41.c" "pasted__skyscraper1textur.c";
connectAttr "pasted__place2dTexture41.tf" "pasted__skyscraper1textur.tf";
connectAttr "pasted__place2dTexture41.rf" "pasted__skyscraper1textur.rf";
connectAttr "pasted__place2dTexture41.mu" "pasted__skyscraper1textur.mu";
connectAttr "pasted__place2dTexture41.mv" "pasted__skyscraper1textur.mv";
connectAttr "pasted__place2dTexture41.s" "pasted__skyscraper1textur.s";
connectAttr "pasted__place2dTexture41.wu" "pasted__skyscraper1textur.wu";
connectAttr "pasted__place2dTexture41.wv" "pasted__skyscraper1textur.wv";
connectAttr "pasted__place2dTexture41.re" "pasted__skyscraper1textur.re";
connectAttr "pasted__place2dTexture41.of" "pasted__skyscraper1textur.of";
connectAttr "pasted__place2dTexture41.r" "pasted__skyscraper1textur.ro";
connectAttr "pasted__place2dTexture41.n" "pasted__skyscraper1textur.n";
connectAttr "pasted__place2dTexture41.vt1" "pasted__skyscraper1textur.vt1";
connectAttr "pasted__place2dTexture41.vt2" "pasted__skyscraper1textur.vt2";
connectAttr "pasted__place2dTexture41.vt3" "pasted__skyscraper1textur.vt3";
connectAttr "pasted__place2dTexture41.vc1" "pasted__skyscraper1textur.vc1";
connectAttr "pasted__place2dTexture41.o" "pasted__skyscraper1textur.uv";
connectAttr "pasted__place2dTexture41.ofs" "pasted__skyscraper1textur.fs";
connectAttr "layerManager.dli[1]" "skyscraper01.id";
connectAttr "pasted__lambert42SG.msg" "pasted__materialInfo41.sg";
connectAttr "skyscraper2texture.msg" "pasted__materialInfo41.m";
connectAttr "pasted__skyscraper2text.msg" "pasted__materialInfo41.t" -na;
connectAttr "skyscraper2texture.oc" "pasted__lambert42SG.ss";
connectAttr "skyscraperShape2.iog" "pasted__lambert42SG.dsm" -na;
connectAttr "pasted__skyscraper2text.oc" "skyscraper2texture.c";
connectAttr "pasted__place2dTexture42.c" "pasted__skyscraper2text.c";
connectAttr "pasted__place2dTexture42.tf" "pasted__skyscraper2text.tf";
connectAttr "pasted__place2dTexture42.rf" "pasted__skyscraper2text.rf";
connectAttr "pasted__place2dTexture42.mu" "pasted__skyscraper2text.mu";
connectAttr "pasted__place2dTexture42.mv" "pasted__skyscraper2text.mv";
connectAttr "pasted__place2dTexture42.s" "pasted__skyscraper2text.s";
connectAttr "pasted__place2dTexture42.wu" "pasted__skyscraper2text.wu";
connectAttr "pasted__place2dTexture42.wv" "pasted__skyscraper2text.wv";
connectAttr "pasted__place2dTexture42.re" "pasted__skyscraper2text.re";
connectAttr "pasted__place2dTexture42.of" "pasted__skyscraper2text.of";
connectAttr "pasted__place2dTexture42.r" "pasted__skyscraper2text.ro";
connectAttr "pasted__place2dTexture42.n" "pasted__skyscraper2text.n";
connectAttr "pasted__place2dTexture42.vt1" "pasted__skyscraper2text.vt1";
connectAttr "pasted__place2dTexture42.vt2" "pasted__skyscraper2text.vt2";
connectAttr "pasted__place2dTexture42.vt3" "pasted__skyscraper2text.vt3";
connectAttr "pasted__place2dTexture42.vc1" "pasted__skyscraper2text.vc1";
connectAttr "pasted__place2dTexture42.o" "pasted__skyscraper2text.uv";
connectAttr "pasted__place2dTexture42.ofs" "pasted__skyscraper2text.fs";
connectAttr "layerManager.dli[2]" "skyscraper02.id";
connectAttr "pasted__lambert43SG.msg" "pasted__materialInfo42.sg";
connectAttr "skyscraper3texture.msg" "pasted__materialInfo42.m";
connectAttr "pasted__skyscraper3textur.msg" "pasted__materialInfo42.t" -na;
connectAttr "skyscraper3texture.oc" "pasted__lambert43SG.ss";
connectAttr "skyscraperShape3.iog" "pasted__lambert43SG.dsm" -na;
connectAttr "pasted__skyscraper3textur.oc" "skyscraper3texture.c";
connectAttr "pasted__place2dTexture43.c" "pasted__skyscraper3textur.c";
connectAttr "pasted__place2dTexture43.tf" "pasted__skyscraper3textur.tf";
connectAttr "pasted__place2dTexture43.rf" "pasted__skyscraper3textur.rf";
connectAttr "pasted__place2dTexture43.mu" "pasted__skyscraper3textur.mu";
connectAttr "pasted__place2dTexture43.mv" "pasted__skyscraper3textur.mv";
connectAttr "pasted__place2dTexture43.s" "pasted__skyscraper3textur.s";
connectAttr "pasted__place2dTexture43.wu" "pasted__skyscraper3textur.wu";
connectAttr "pasted__place2dTexture43.wv" "pasted__skyscraper3textur.wv";
connectAttr "pasted__place2dTexture43.re" "pasted__skyscraper3textur.re";
connectAttr "pasted__place2dTexture43.of" "pasted__skyscraper3textur.of";
connectAttr "pasted__place2dTexture43.r" "pasted__skyscraper3textur.ro";
connectAttr "pasted__place2dTexture43.n" "pasted__skyscraper3textur.n";
connectAttr "pasted__place2dTexture43.vt1" "pasted__skyscraper3textur.vt1";
connectAttr "pasted__place2dTexture43.vt2" "pasted__skyscraper3textur.vt2";
connectAttr "pasted__place2dTexture43.vt3" "pasted__skyscraper3textur.vt3";
connectAttr "pasted__place2dTexture43.vc1" "pasted__skyscraper3textur.vc1";
connectAttr "pasted__place2dTexture43.o" "pasted__skyscraper3textur.uv";
connectAttr "pasted__place2dTexture43.ofs" "pasted__skyscraper3textur.fs";
connectAttr "layerManager.dli[3]" "skyscraper03.id";
connectAttr "pasted__lambert44SG.msg" "pasted__materialInfo43.sg";
connectAttr "skyscraper4texture.msg" "pasted__materialInfo43.m";
connectAttr "pasted__skyscraper4textur.msg" "pasted__materialInfo43.t" -na;
connectAttr "skyscraper4texture.oc" "pasted__lambert44SG.ss";
connectAttr "skyscraperShape4.iog" "pasted__lambert44SG.dsm" -na;
connectAttr "pasted__skyscraper4textur.oc" "skyscraper4texture.c";
connectAttr "pasted__place2dTexture44.c" "pasted__skyscraper4textur.c";
connectAttr "pasted__place2dTexture44.tf" "pasted__skyscraper4textur.tf";
connectAttr "pasted__place2dTexture44.rf" "pasted__skyscraper4textur.rf";
connectAttr "pasted__place2dTexture44.mu" "pasted__skyscraper4textur.mu";
connectAttr "pasted__place2dTexture44.mv" "pasted__skyscraper4textur.mv";
connectAttr "pasted__place2dTexture44.s" "pasted__skyscraper4textur.s";
connectAttr "pasted__place2dTexture44.wu" "pasted__skyscraper4textur.wu";
connectAttr "pasted__place2dTexture44.wv" "pasted__skyscraper4textur.wv";
connectAttr "pasted__place2dTexture44.re" "pasted__skyscraper4textur.re";
connectAttr "pasted__place2dTexture44.of" "pasted__skyscraper4textur.of";
connectAttr "pasted__place2dTexture44.r" "pasted__skyscraper4textur.ro";
connectAttr "pasted__place2dTexture44.n" "pasted__skyscraper4textur.n";
connectAttr "pasted__place2dTexture44.vt1" "pasted__skyscraper4textur.vt1";
connectAttr "pasted__place2dTexture44.vt2" "pasted__skyscraper4textur.vt2";
connectAttr "pasted__place2dTexture44.vt3" "pasted__skyscraper4textur.vt3";
connectAttr "pasted__place2dTexture44.vc1" "pasted__skyscraper4textur.vc1";
connectAttr "pasted__place2dTexture44.o" "pasted__skyscraper4textur.uv";
connectAttr "pasted__place2dTexture44.ofs" "pasted__skyscraper4textur.fs";
connectAttr "layerManager.dli[4]" "skyscraper04.id";
connectAttr "pasted__lambert45SG.msg" "pasted__materialInfo44.sg";
connectAttr "skyscraper5texture.msg" "pasted__materialInfo44.m";
connectAttr "pasted__skyscraper5textur.msg" "pasted__materialInfo44.t" -na;
connectAttr "skyscraper5texture.oc" "pasted__lambert45SG.ss";
connectAttr "skyscraperShape5.iog" "pasted__lambert45SG.dsm" -na;
connectAttr "pasted__skyscraper5textur.oc" "skyscraper5texture.c";
connectAttr "pasted__place2dTexture45.c" "pasted__skyscraper5textur.c";
connectAttr "pasted__place2dTexture45.tf" "pasted__skyscraper5textur.tf";
connectAttr "pasted__place2dTexture45.rf" "pasted__skyscraper5textur.rf";
connectAttr "pasted__place2dTexture45.mu" "pasted__skyscraper5textur.mu";
connectAttr "pasted__place2dTexture45.mv" "pasted__skyscraper5textur.mv";
connectAttr "pasted__place2dTexture45.s" "pasted__skyscraper5textur.s";
connectAttr "pasted__place2dTexture45.wu" "pasted__skyscraper5textur.wu";
connectAttr "pasted__place2dTexture45.wv" "pasted__skyscraper5textur.wv";
connectAttr "pasted__place2dTexture45.re" "pasted__skyscraper5textur.re";
connectAttr "pasted__place2dTexture45.of" "pasted__skyscraper5textur.of";
connectAttr "pasted__place2dTexture45.r" "pasted__skyscraper5textur.ro";
connectAttr "pasted__place2dTexture45.n" "pasted__skyscraper5textur.n";
connectAttr "pasted__place2dTexture45.vt1" "pasted__skyscraper5textur.vt1";
connectAttr "pasted__place2dTexture45.vt2" "pasted__skyscraper5textur.vt2";
connectAttr "pasted__place2dTexture45.vt3" "pasted__skyscraper5textur.vt3";
connectAttr "pasted__place2dTexture45.vc1" "pasted__skyscraper5textur.vc1";
connectAttr "pasted__place2dTexture45.o" "pasted__skyscraper5textur.uv";
connectAttr "pasted__place2dTexture45.ofs" "pasted__skyscraper5textur.fs";
connectAttr "layerManager.dli[5]" "skyscraper05.id";
connectAttr "pasted__lambert46SG.msg" "pasted__materialInfo45.sg";
connectAttr "skyscraper6texture.msg" "pasted__materialInfo45.m";
connectAttr "pasted__file45.msg" "pasted__materialInfo45.t" -na;
connectAttr "skyscraper6texture.oc" "pasted__lambert46SG.ss";
connectAttr "skyscraperShape6.iog" "pasted__lambert46SG.dsm" -na;
connectAttr "pasted__file45.oc" "skyscraper6texture.c";
connectAttr "pasted__place2dTexture46.c" "pasted__file45.c";
connectAttr "pasted__place2dTexture46.tf" "pasted__file45.tf";
connectAttr "pasted__place2dTexture46.rf" "pasted__file45.rf";
connectAttr "pasted__place2dTexture46.mu" "pasted__file45.mu";
connectAttr "pasted__place2dTexture46.mv" "pasted__file45.mv";
connectAttr "pasted__place2dTexture46.s" "pasted__file45.s";
connectAttr "pasted__place2dTexture46.wu" "pasted__file45.wu";
connectAttr "pasted__place2dTexture46.wv" "pasted__file45.wv";
connectAttr "pasted__place2dTexture46.re" "pasted__file45.re";
connectAttr "pasted__place2dTexture46.of" "pasted__file45.of";
connectAttr "pasted__place2dTexture46.r" "pasted__file45.ro";
connectAttr "pasted__place2dTexture46.n" "pasted__file45.n";
connectAttr "pasted__place2dTexture46.vt1" "pasted__file45.vt1";
connectAttr "pasted__place2dTexture46.vt2" "pasted__file45.vt2";
connectAttr "pasted__place2dTexture46.vt3" "pasted__file45.vt3";
connectAttr "pasted__place2dTexture46.vc1" "pasted__file45.vc1";
connectAttr "pasted__place2dTexture46.o" "pasted__file45.uv";
connectAttr "pasted__place2dTexture46.ofs" "pasted__file45.fs";
connectAttr "layerManager.dli[6]" "skyscraper06.id";
connectAttr "pasted__pasted__lambert47SG.msg" "pasted__pasted__materialInfo46.sg"
		;
connectAttr "pasted__debugareatexture.msg" "pasted__pasted__materialInfo46.m";
connectAttr "pasted__pasted__file46.msg" "pasted__pasted__materialInfo46.t" -na;
connectAttr "pasted__debugareatexture.oc" "pasted__pasted__lambert47SG.ss";
connectAttr "pasted__pasted__file46.oc" "pasted__debugareatexture.c";
connectAttr "pasted__pasted__place2dTexture47.c" "pasted__pasted__file46.c";
connectAttr "pasted__pasted__place2dTexture47.tf" "pasted__pasted__file46.tf";
connectAttr "pasted__pasted__place2dTexture47.rf" "pasted__pasted__file46.rf";
connectAttr "pasted__pasted__place2dTexture47.mu" "pasted__pasted__file46.mu";
connectAttr "pasted__pasted__place2dTexture47.mv" "pasted__pasted__file46.mv";
connectAttr "pasted__pasted__place2dTexture47.s" "pasted__pasted__file46.s";
connectAttr "pasted__pasted__place2dTexture47.wu" "pasted__pasted__file46.wu";
connectAttr "pasted__pasted__place2dTexture47.wv" "pasted__pasted__file46.wv";
connectAttr "pasted__pasted__place2dTexture47.re" "pasted__pasted__file46.re";
connectAttr "pasted__pasted__place2dTexture47.of" "pasted__pasted__file46.of";
connectAttr "pasted__pasted__place2dTexture47.r" "pasted__pasted__file46.ro";
connectAttr "pasted__pasted__place2dTexture47.n" "pasted__pasted__file46.n";
connectAttr "pasted__pasted__place2dTexture47.vt1" "pasted__pasted__file46.vt1";
connectAttr "pasted__pasted__place2dTexture47.vt2" "pasted__pasted__file46.vt2";
connectAttr "pasted__pasted__place2dTexture47.vt3" "pasted__pasted__file46.vt3";
connectAttr "pasted__pasted__place2dTexture47.vc1" "pasted__pasted__file46.vc1";
connectAttr "pasted__pasted__place2dTexture47.o" "pasted__pasted__file46.uv";
connectAttr "pasted__pasted__place2dTexture47.ofs" "pasted__pasted__file46.fs";
connectAttr "pasted__lambert4SG.msg" "pasted__materialInfo3.sg";
connectAttr "pasted__workertexture.msg" "pasted__materialInfo3.m";
connectAttr "pasted__file2.msg" "pasted__materialInfo3.t" -na;
connectAttr "pasted__workertexture.oc" "pasted__lambert4SG.ss";
connectAttr "pasted__file2.oc" "pasted__workertexture.c";
connectAttr "pasted__place2dTexture3.c" "pasted__file2.c";
connectAttr "pasted__place2dTexture3.tf" "pasted__file2.tf";
connectAttr "pasted__place2dTexture3.rf" "pasted__file2.rf";
connectAttr "pasted__place2dTexture3.mu" "pasted__file2.mu";
connectAttr "pasted__place2dTexture3.mv" "pasted__file2.mv";
connectAttr "pasted__place2dTexture3.s" "pasted__file2.s";
connectAttr "pasted__place2dTexture3.wu" "pasted__file2.wu";
connectAttr "pasted__place2dTexture3.wv" "pasted__file2.wv";
connectAttr "pasted__place2dTexture3.re" "pasted__file2.re";
connectAttr "pasted__place2dTexture3.of" "pasted__file2.of";
connectAttr "pasted__place2dTexture3.r" "pasted__file2.ro";
connectAttr "pasted__place2dTexture3.n" "pasted__file2.n";
connectAttr "pasted__place2dTexture3.vt1" "pasted__file2.vt1";
connectAttr "pasted__place2dTexture3.vt2" "pasted__file2.vt2";
connectAttr "pasted__place2dTexture3.vt3" "pasted__file2.vt3";
connectAttr "pasted__place2dTexture3.vc1" "pasted__file2.vc1";
connectAttr "pasted__place2dTexture3.o" "pasted__file2.uv";
connectAttr "pasted__place2dTexture3.ofs" "pasted__file2.fs";
connectAttr "pasted__lambert41SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert42SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert43SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert44SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert45SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert46SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__pasted__lambert47SG.pa" ":renderPartition.st" -na;
connectAttr "pasted__lambert4SG.pa" ":renderPartition.st" -na;
connectAttr "skyscraper1texture.msg" ":defaultShaderList1.s" -na;
connectAttr "skyscraper2texture.msg" ":defaultShaderList1.s" -na;
connectAttr "skyscraper3texture.msg" ":defaultShaderList1.s" -na;
connectAttr "skyscraper4texture.msg" ":defaultShaderList1.s" -na;
connectAttr "skyscraper5texture.msg" ":defaultShaderList1.s" -na;
connectAttr "skyscraper6texture.msg" ":defaultShaderList1.s" -na;
connectAttr "pasted__debugareatexture.msg" ":defaultShaderList1.s" -na;
connectAttr "pasted__workertexture.msg" ":defaultShaderList1.s" -na;
connectAttr "pasted__skyscraper1textur.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__skyscraper2text.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__skyscraper3textur.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__skyscraper4textur.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__skyscraper5textur.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__file45.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__pasted__file46.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__file2.msg" ":defaultTextureList1.tx" -na;
connectAttr "pasted__place2dTexture41.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__place2dTexture42.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__place2dTexture43.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__place2dTexture44.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__place2dTexture45.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__place2dTexture46.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "pasted__pasted__place2dTexture47.msg" ":defaultRenderUtilityList1.u"
		 -na;
connectAttr "pasted__place2dTexture3.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
// End of skyscrapers.ma
