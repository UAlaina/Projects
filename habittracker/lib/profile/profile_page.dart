import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:flutter/material.dart';
import 'package:habittracker/models/user_data.dart';
import 'package:provider/provider.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({Key? key}) : super(key: key);

  @override
  State<ProfilePage> createState() => _ProfilePageState();
}

class _ProfilePageState extends State<ProfilePage> {
  final FirebaseFirestore _firestore = FirebaseFirestore.instance;
  Map<String, dynamic> userData = {};
  bool isLoading = true;
  String? errorMessage;

  @override
  void initState() {
    super.initState();
    WidgetsBinding.instance.addPostFrameCallback((_) {
      _loadUserData();
    });
  }

  Future<void> _loadUserData() async {
    print('ProfilePage: Starting _loadUserData');
    try {
      String? userId = Provider.of<UserData>(context, listen: false).docId;
      print('ProfilePage: User ID: $userId');

      if (userId == null || userId.isEmpty) {
        setState(() {
          isLoading = false;
          errorMessage = 'User ID is null or empty. Please log in again.';
        });
        print('ProfilePage: Error: User ID is null or empty');
        return;
      }

      print('ProfilePage: Fetching document from Firestore for userId: $userId');
      final doc = await _firestore.collection('users').doc(userId).get();
      print('ProfilePage: Document exists: ${doc.exists}');

      if (doc.exists) {
        setState(() {
          userData = doc.data() ?? {};
          isLoading = false;
          errorMessage = null;
        });
        print('ProfilePage: User data loaded: $userData');
      } else {
        setState(() {
          isLoading = false;
          errorMessage = 'User document does not exist.';
        });
        print('ProfilePage: Error: User document does not exist');
      }
    } catch (e) {
      setState(() {
        isLoading = false;
        errorMessage = 'Error fetching user data: $e';
      });
      print('ProfilePage: Error fetching user data: $e');
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Profile'),
        backgroundColor: Colors.blue,
      ),
      body: isLoading
          ? const Center(child: CircularProgressIndicator())
          : Padding(
        padding: const EdgeInsets.all(24.0),
        child: errorMessage != null
            ? Center(child: Text(errorMessage!, style: const TextStyle(fontSize: 18, color: Colors.red)))
            : userData.isEmpty
            ? const Center(child: Text('No user data available', style: TextStyle(fontSize: 18)))
            : ListView(
          children: userData.entries.map((entry) {
            return Padding(
              padding: const EdgeInsets.symmetric(vertical: 5.0),
              child: Text(
                '${entry.key}: ${entry.value.toString()}',
                style: const TextStyle(fontSize: 18),
              ),
            );
          }).toList(),
        ),
      ),
    );
  }
}