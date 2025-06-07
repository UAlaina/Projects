<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chat List</title>
    <link rel="stylesheet" type="text/css" href="/NurseProject/Views/styles/chatList.css">
</head>

<div style="padding: 10px; max-width: 700px; margin: auto;">
    <span style="cursor: pointer; font-size: 24px;" onclick="window.location.href='/NurseProject/<?= $userType ?>/mainpage'">← Back</span>
</div>

<h2>Your Conversations</h2>

<div class="chat-list" style="max-width: 700px; margin: auto;">
    <?php if (!empty($chats)): ?>
        <ul>
            <?php foreach ($chats as $chat): ?>
                <li style="margin-bottom: 10px;">
                    <a href="/NurseProject/chat/view/<?= $chat->chatRoomId ?>">
                        <?php if ($userType === 'nurse'): ?>
                            <strong><?= htmlspecialchars($chat->clientFirstName . ' ' . $chat->clientLastName) ?></strong>
                        <?php else: ?>
                            <strong><?= htmlspecialchars($chat->nurseFirstName . ' ' . $chat->nurseLastName) ?></strong>
                        <?php endif; ?>
                        <br>
                        Last message: <?= isset($chat->lastMessageTime) ? $chat->lastMessageTime : $chat->createAt ?>
                        <?php if ($chat->unreadCount > 0): ?>
                            <strong>(<?= $chat->unreadCount ?> new)</strong>
                        <?php endif; ?>
                    </a>
                </li>
            <?php endforeach; ?>
        </ul>
    <?php else: ?>
        <p>You have no active chats.</p>
    <?php endif; ?>
</div>
