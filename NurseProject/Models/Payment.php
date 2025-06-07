<?php
include_once "Models/Model.php";

class Payment {
    public $paymentID;
    public $patientID;
    public $transactionID;
    public $serviceCode;
    public $amount;
    public $timeStamp;
    public $paymentStatus;
    public $paymentMethod;
    public $processorID;
    public $stripeID;
    public $paypalID;

    function __construct($param = null) {
        if (is_object($param)) {
            $this->setProperties($param);
        } elseif (is_int($param)) {
            $conn = Model::connect();

            $sql = "SELECT * FROM `payments` WHERE paymentID = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param("i", $param);
            $stmt->execute();

            $result = $stmt->get_result();
            $row = $result->fetch_object();

            $this->setProperties($row);
        }
    }

    private function setProperties($param) {
        if (is_object($param)) {
            $this->paymentID = $param->paymentID;
            $this->patientID = $param->patientID;
            $this->transactionID = $param->transactionID;
            $this->serviceCode = $param->serviceCode;
            $this->amount = $param->amount;
            $this->timeStamp = $param->timeStamp;
            $this->paymentStatus = $param->paymentStatus;
            $this->paymentMethod = $param->paymentMethod;
            $this->processorID = $param->processorID;
            $this->stripeID = $param->stripeID;
            $this->paypalID = $param->paypalID;
        } elseif (is_array($param)) {
            $this->paymentID = $param['paymentID'];
            $this->patientID = $param['patientID'];
            $this->transactionID = $param['transactionID'];
            $this->serviceCode = $param['serviceCode'];
            $this->amount = $param['amount'];
            $this->timeStamp = $param['timeStamp'];
            $this->paymentStatus = $param['paymentStatus'];
            $this->paymentMethod = $param['paymentMethod'];
            $this->processorID = $param['processorID'];
            $this->stripeID = $param['stripeID'];
            $this->paypalID = $param['paypalID'];
        }
    }

    public static function list() {
        $list = [];
        $sql = "SELECT * FROM `payment`";

        $connection = Model::connect();
        $result = $connection->query($sql);

        while ($row = $result->fetch_object()) {
            $payment = new Payment($row);
            array_push($list, $payment);
        }

        return $list;
    }

    public static function insert($data) {
    $conn = Model::connect();

    $stmt = $conn->prepare("
        INSERT INTO payments (patientName, serviceCode, amount, paymentStatus)
        VALUES (?, ?, ?, 'Pending')
    ");

    $stmt->bind_param("ssd", $data['patient_name'], $data['service_code'], $data['amount']);

    return $stmt->execute();
}


public static function getPaymentHistory($patientID) {
    $conn = Model::connect();
    $stmt = $conn->prepare("SELECT * FROM payments WHERE patientID = ?");
    $stmt->bind_param("i", $patientID);
    $stmt->execute();
    $result = $stmt->get_result();

    $payments = [];
    while ($row = $result->fetch_object()) {
        $payments[] = $row;
    }

    return $payments;
}
}
?>